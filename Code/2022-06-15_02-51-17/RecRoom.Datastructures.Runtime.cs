using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BNCCLJHOHMJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D8C0", Offset = "0x69C4C0", VA = "0x18069D8C0")]
	public BNCCLJHOHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9430", Offset = "0x4DA8030", VA = "0x184DA9430")]
	public byte[] CMHJDNANJKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CAKPBNBCLHF(IncrementalHash AOGNKGPBPLM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xC724B0", Offset = "0xC710B0", VA = "0x180C724B0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
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
	[PNKOCEBJOFO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[PNKOCEBJOFO]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB1C0", Offset = "0x4DA9DC0", VA = "0x184DAB1C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB180", Offset = "0x4DA9D80", VA = "0x184DAB180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB200", Offset = "0x4DA9E00", VA = "0x184DAB200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB410", Offset = "0x4DAA010", VA = "0x184DAB410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB380", Offset = "0x4DA9F80", VA = "0x184DAB380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE4FC60", Offset = "0xE4E860", VA = "0x180E4FC60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEDFF90", Offset = "0xEDEB90", VA = "0x180EDFF90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB140", Offset = "0x4DA9D40", VA = "0x184DAB140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB2F0", Offset = "0x4DA9EF0", VA = "0x184DAB2F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4DAAB70", Offset = "0x4DA9770", VA = "0x184DAAB70")]
	public void CopyBounds(SavedExtents PJEOMNDGEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB0B0", Offset = "0x4DA9CB0", VA = "0x184DAB0B0")]
	public void SetLocalSpaceBounds(Bounds NCEGAEGEEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FAAE0", Offset = "0x7F96E0", VA = "0x1807FAAE0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB0A0", Offset = "0x4DA9CA0", VA = "0x184DAB0A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DAABA0", Offset = "0x4DA97A0", VA = "0x184DAABA0")]
	private void EJGAHNNFCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DAAE70", Offset = "0x4DA9A70", VA = "0x184DAAE70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA5B0", Offset = "0x4DA91B0", VA = "0x184DAA5B0")]
	public static void CalculateLocalBoundsFor(GameObject JNOODOEOLDA, out Bounds NCEGAEGEEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DAADB0", Offset = "0x4DA99B0", VA = "0x184DAADB0")]
	private static void OEPBKHLBOMJ(Bounds GONCOEMNHPC, Color PKPFJHLMNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB0D0", Offset = "0x4DA9CD0", VA = "0x184DAB0D0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55CEE0", Offset = "0x55BAE0", VA = "0x18055CEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "4")]
	public virtual void IAMPGMLNCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[BNCCLJHOHMJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2905560", Offset = "0x2904160", VA = "0x182905560", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29050A0", Offset = "0x2903CA0", VA = "0x1829050A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2905B60", Offset = "0x2904760", VA = "0x182905B60")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PGMGPMFEGDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public PGMGPMFEGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x329E340", Offset = "0x329CF40", VA = "0x18329E340")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[BNCCLJHOHMJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x329A3A0", Offset = "0x3298FA0", VA = "0x18329A3A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x329A3D0", Offset = "0x3298FD0", VA = "0x18329A3D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x329A2F0", Offset = "0x3298EF0", VA = "0x18329A2F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey OMAJLLKKGPH]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x329A320", Offset = "0x3298F20", VA = "0x18329A320", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x329A1F0", Offset = "0x3298DF0", VA = "0x18329A1F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3299A50", Offset = "0x3298650", VA = "0x183299A50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32993C0", Offset = "0x3297FC0", VA = "0x1832993C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3298FC0", Offset = "0x3297BC0", VA = "0x183298FC0", Slot = "14")]
	protected virtual string ICOKFDHGBNM(TKeyVal MKDJGGJGDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3298F00", Offset = "0x3297B00", VA = "0x183298F00", Slot = "4")]
	public bool ContainsKey(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x329A0E0", Offset = "0x3298CE0", VA = "0x18329A0E0", Slot = "5")]
	public bool TryGetValue(TKey OMAJLLKKGPH, out TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3298F30", Offset = "0x3297B30", VA = "0x183298F30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3298F30", Offset = "0x3297B30", VA = "0x183298F30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x329A110", Offset = "0x3298D10", VA = "0x18329A110")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BHADJAPDOPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PKMGLIBMDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public PKMGLIBMDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB1A0", Offset = "0x2AC9DA0", VA = "0x182ACB1A0")]
		internal bool <GetSamples>b__0(global::GKDODOGLPIN<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float EDIFNKDKPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float AOIOICIDDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GKDODOGLPIN<float, T>> LMPPHPIGEKB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DJPGMLNGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2AB92E0", Offset = "0x2AB7EE0", VA = "0x182AB92E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AB97C0", Offset = "0x2AB83C0", VA = "0x182AB97C0")]
	public BHADJAPDOPE(float CMBPOGCBKIO, float FDFJLEOHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9540", Offset = "0x2AB8140", VA = "0x182AB9540")]
	public bool KFBLLFMIJIK(float NKDHHFHECJM, T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AB96A0", Offset = "0x2AB82A0", VA = "0x182AB96A0")]
	public int MBNJCAIMFFG(float NKDHHFHECJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8C60", Offset = "0x2AB7860", VA = "0x182AB8C60")]
	public IEnumerable<T> EOINEJJDBAK(float NKDHHFHECJM, [Optional] float? NBKALNPEPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8C30", Offset = "0x2AB7830", VA = "0x182AB8C30")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9700", Offset = "0x2AB8300", VA = "0x182AB9700")]
	private void NJDCJMJCLPO(float NKDHHFHECJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GAGEFMJKOND<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FECGOHOGJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T HNBDKKLMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float KFLKAGHBBBA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float IFLDLBNGOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> KACJAGICCOH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int CELHJFOLNDG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private FECGOHOGJKP[] IIIEKHDFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NDDPBFFIOAD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MILDIHHBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xFFD4F0", Offset = "0xFFC0F0", VA = "0x180FFD4F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFFD520", Offset = "0xFFC120", VA = "0x180FFD520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3842AE0", Offset = "0x38416E0", VA = "0x183842AE0")]
	public GAGEFMJKOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3842A00", Offset = "0x3841600", VA = "0x183842A00")]
	public GAGEFMJKOND(int BNLHOMCBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3842060", Offset = "0x3840C60", VA = "0x183842060")]
	public void DNJODILJGAL(float NKDHHFHECJM, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3841770", Offset = "0x3840370", VA = "0x183841770")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38418C0", Offset = "0x38404C0", VA = "0x1838418C0")]
	public bool BBCPIEOHCNN(float NFNLHAEHMAI, float IJLBPBGBPGB, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3842450", Offset = "0x3841050", VA = "0x183842450")]
	public bool JNINKMFDFEJ(float NFNLHAEHMAI, float IJLBPBGBPGB, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3842700", Offset = "0x3841300", VA = "0x183842700")]
	public void OAJNFDENFFO(float NFNLHAEHMAI, float IJLBPBGBPGB, List<T> EINFEEMFPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3841E50", Offset = "0x3840A50", VA = "0x183841E50")]
	private int DBEJGEGBJGC(int FKCNFGKMKNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3841E80", Offset = "0x3840A80", VA = "0x183841E80")]
	private void DIKJEAJIGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JEGKFIOAFIF();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FJEPJJKDNOE(T DMGEENBOIFD, T CGDAAEMLLFJ, float NHMGOELDBCA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CNANGHGKLGC(T ODCJDJDBONO, float NHMGOELDBCA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OGEPJGHKHBG(T DMGEENBOIFD, T CGDAAEMLLFJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GBDFABLPOID(T DMGEENBOIFD, T CGDAAEMLLFJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FEBOONHCIOA : global::GAGEFMJKOND<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6C60", Offset = "0x4DA5860", VA = "0x184DA6C60", Slot = "4")]
	protected override Vector3 JEGKFIOAFIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6B30", Offset = "0x4DA5730", VA = "0x184DA6B30", Slot = "5")]
	protected override Vector3 FJEPJJKDNOE(Vector3 DMGEENBOIFD, Vector3 CGDAAEMLLFJ, float NHMGOELDBCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6A90", Offset = "0x4DA5690", VA = "0x184DA6A90", Slot = "6")]
	protected override Vector3 CNANGHGKLGC(Vector3 ODCJDJDBONO, float NHMGOELDBCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6CD0", Offset = "0x4DA58D0", VA = "0x184DA6CD0", Slot = "7")]
	protected override Vector3 OGEPJGHKHBG(Vector3 DMGEENBOIFD, Vector3 CGDAAEMLLFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6BF0", Offset = "0x4DA57F0", VA = "0x184DA6BF0", Slot = "8")]
	protected override Vector3 GBDFABLPOID(Vector3 DMGEENBOIFD, Vector3 CGDAAEMLLFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6D80", Offset = "0x4DA5980", VA = "0x184DA6D80")]
	public FEBOONHCIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AKMPKFICDOK : global::GAGEFMJKOND<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5A20", Offset = "0x4DA4620", VA = "0x184DA5A20")]
	public AKMPKFICDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5A80", Offset = "0x4DA4680", VA = "0x184DA5A80")]
	public AKMPKFICDOK(int BNLHOMCBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xD72BC0", Offset = "0xD717C0", VA = "0x180D72BC0", Slot = "4")]
	protected override float JEGKFIOAFIF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5990", Offset = "0x4DA4590", VA = "0x184DA5990", Slot = "5")]
	protected override float FJEPJJKDNOE(float DMGEENBOIFD, float CGDAAEMLLFJ, float NHMGOELDBCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6270", Offset = "0x3DF4E70", VA = "0x183DF6270", Slot = "6")]
	protected override float CNANGHGKLGC(float ODCJDJDBONO, float NHMGOELDBCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1B4CC80", Offset = "0x1B4B880", VA = "0x181B4CC80", Slot = "7")]
	protected override float OGEPJGHKHBG(float DMGEENBOIFD, float CGDAAEMLLFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5A10", Offset = "0x4DA4610", VA = "0x184DA5A10", Slot = "8")]
	protected override float GBDFABLPOID(float DMGEENBOIFD, float CGDAAEMLLFJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NAANJCOPGKC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBCF0", Offset = "0x1CDA8F0", VA = "0x181CDBCF0")]
	public static global::IKFHBIOIOGB<T1> KGHLJHHMDNN<T1>(T1 OCDLKMLIIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBBB0", Offset = "0x1CDA7B0", VA = "0x181CDBBB0")]
	public static global::GKDODOGLPIN<T1, T2> KGHLJHHMDNN<T1, T2>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2CA0", Offset = "0x1DE18A0", VA = "0x181DE2CA0")]
	public static global::NEMJBIOKDGP<T1, T2, T3> KGHLJHHMDNN<T1, T2, T3>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1CDC1B0", Offset = "0x1CDADB0", VA = "0x181CDC1B0")]
	public static global::MNMHMENJILL<T1, T2, T3, T4> KGHLJHHMDNN<T1, T2, T3, T4>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A93EC0", Offset = "0x2A92AC0", VA = "0x182A93EC0")]
	public static global::FHLGGCCPCMC<T1, T2, T3, T4, T5> KGHLJHHMDNN<T1, T2, T3, T4, T5>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x20FE1D0", Offset = "0x20FCDD0", VA = "0x1820FE1D0")]
	public static global::CDIKPHJJHGH<T1, T2, T3, T4, T5, T6> KGHLJHHMDNN<T1, T2, T3, T4, T5, T6>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2D30", Offset = "0x1DE1930", VA = "0x181DE2D30")]
	public static global::MEMGFPHGEPB<T1, T2, T3, T4, T5, T6, T7> KGHLJHHMDNN<T1, T2, T3, T4, T5, T6, T7>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK, T7 EOAKKEADPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBC20", Offset = "0x1CDA820", VA = "0x181CDBC20")]
	public static global::KBJEGNAPODD<T1, T2, T3, T4, T5, T6, T7, T8> KGHLJHHMDNN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK, T7 EOAKKEADPHF, T8 NCNPFFHPJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x18D91B0", Offset = "0x18D7DB0", VA = "0x1818D91B0")]
	[IteratorStateMachine(typeof(MOGNIEMDEMF))]
	public static IEnumerable<global::GKDODOGLPIN<T1, T2>> LBCELGAJONM<T1, T2>(IEnumerable<T1> BDJKEBGEAJO, IEnumerable<T2> GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A9C690", Offset = "0x1A9B290", VA = "0x181A9C690")]
	[IteratorStateMachine(typeof(AGEPDCBIGKN))]
	public static IEnumerable<global::NEMJBIOKDGP<T1, T2, T3>> LBCELGAJONM<T1, T2, T3>(IEnumerable<T1> BDJKEBGEAJO, IEnumerable<T2> GONCOEMNHPC, IEnumerable<T3> PKPFJHLMNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2390610", Offset = "0x238F210", VA = "0x182390610")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44E92D0", Offset = "0x44E7ED0", VA = "0x1844E92D0")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x44E92E0", Offset = "0x44E7EE0", VA = "0x1844E92E0")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC, int FFPJBFJIAKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9590", Offset = "0x4DA8190", VA = "0x184DA9590")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC, int FFPJBFJIAKO, int LAMJBJJBNGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9540", Offset = "0x4DA8140", VA = "0x184DA9540")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC, int FFPJBFJIAKO, int LAMJBJJBNGK, int PMOMKNGMIHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9560", Offset = "0x4DA8160", VA = "0x184DA9560")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC, int FFPJBFJIAKO, int LAMJBJJBNGK, int PMOMKNGMIHM, int GBAHCOOKIGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9510", Offset = "0x4DA8110", VA = "0x184DA9510")]
	internal static int PJPOIJNHHFD(int LDCOAGHNLJH, int KNPOLLPBIDC, int ICMIKCCCNHC, int FFPJBFJIAKO, int LAMJBJJBNGK, int PMOMKNGMIHM, int GBAHCOOKIGL, int BFGIEPCEDEG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IKFHBIOIOGB<T1> : IComparable<global::IKFHBIOIOGB<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
	public IKFHBIOIOGB(T1 OCDLKMLIIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27E5470", Offset = "0x27E4070", VA = "0x1827E5470", Slot = "4")]
	public int CompareTo(global::IKFHBIOIOGB<T1> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27E54E0", Offset = "0x27E40E0", VA = "0x1827E54E0", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5A0", Offset = "0x7EC1A0", VA = "0x1807ED5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x27E5580", Offset = "0x27E4180", VA = "0x1827E5580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GKDODOGLPIN<T1, T2> : IComparable<global::GKDODOGLPIN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33E2800", Offset = "0x33E1400", VA = "0x1833E2800")]
	public GKDODOGLPIN(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38AF6A0", Offset = "0x38AE2A0", VA = "0x1838AF6A0", Slot = "4")]
	public int CompareTo(global::GKDODOGLPIN<T1, T2> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38AFA30", Offset = "0x38AE630", VA = "0x1838AFA30", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38B0600", Offset = "0x38AF200", VA = "0x1838B0600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38B0E40", Offset = "0x38AFA40", VA = "0x1838B0E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NEMJBIOKDGP<T1, T2, T3> : IComparable<global::NEMJBIOKDGP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x28D48B0", Offset = "0x28D34B0", VA = "0x1828D48B0")]
	public NEMJBIOKDGP(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x28D40D0", Offset = "0x28D2CD0", VA = "0x1828D40D0", Slot = "4")]
	public int CompareTo(global::NEMJBIOKDGP<T1, T2, T3> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28D43C0", Offset = "0x28D2FC0", VA = "0x1828D43C0", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28D45C0", Offset = "0x28D31C0", VA = "0x1828D45C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28D4630", Offset = "0x28D3230", VA = "0x1828D4630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MNMHMENJILL<T1, T2, T3, T4> : IComparable<global::MNMHMENJILL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 ONMCHOODHDO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x25891D0", Offset = "0x2587DD0", VA = "0x1825891D0")]
	public MNMHMENJILL(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFBD0", Offset = "0x3CFE7D0", VA = "0x183CFFBD0", Slot = "4")]
	public int CompareTo(global::MNMHMENJILL<T1, T2, T3, T4> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFD10", Offset = "0x3CFE910", VA = "0x183CFFD10", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFE30", Offset = "0x3CFEA30", VA = "0x183CFFE30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFEF0", Offset = "0x3CFEAF0", VA = "0x183CFFEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FHLGGCCPCMC<T1, T2, T3, T4, T5> : IComparable<global::FHLGGCCPCMC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 ONMCHOODHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 JIJDCLCFHHI;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0")]
	public FHLGGCCPCMC(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3D281E0", Offset = "0x3D26DE0", VA = "0x183D281E0", Slot = "4")]
	public int CompareTo(global::FHLGGCCPCMC<T1, T2, T3, T4, T5> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D28360", Offset = "0x3D26F60", VA = "0x183D28360", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D284A0", Offset = "0x3D270A0", VA = "0x183D284A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D285A0", Offset = "0x3D271A0", VA = "0x183D285A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CDIKPHJJHGH<T1, T2, T3, T4, T5, T6> : IComparable<global::CDIKPHJJHGH<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 ONMCHOODHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 JIJDCLCFHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 OEGFJJOCMAM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E84380", Offset = "0x2E82F80", VA = "0x182E84380")]
	public CDIKPHJJHGH(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E83DE0", Offset = "0x2E829E0", VA = "0x182E83DE0", Slot = "4")]
	public int CompareTo(global::CDIKPHJJHGH<T1, T2, T3, T4, T5, T6> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E83FA0", Offset = "0x2E82BA0", VA = "0x182E83FA0", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E84110", Offset = "0x2E82D10", VA = "0x182E84110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E84230", Offset = "0x2E82E30", VA = "0x182E84230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MEMGFPHGEPB<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::MEMGFPHGEPB<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 ONMCHOODHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 JIJDCLCFHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 OEGFJJOCMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 MANOPHMCEKO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x258A7C0", Offset = "0x25893C0", VA = "0x18258A7C0")]
	public MEMGFPHGEPB(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK, T7 EOAKKEADPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x258A160", Offset = "0x2588D60", VA = "0x18258A160", Slot = "4")]
	public int CompareTo(global::MEMGFPHGEPB<T1, T2, T3, T4, T5, T6, T7> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x258A360", Offset = "0x2588F60", VA = "0x18258A360", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x258A500", Offset = "0x2589100", VA = "0x18258A500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x258A650", Offset = "0x2589250", VA = "0x18258A650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KBJEGNAPODD<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::KBJEGNAPODD<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 HIADMHHKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 FAALKJPBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 CBBJCBDALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 ONMCHOODHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 JIJDCLCFHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 OEGFJJOCMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 MANOPHMCEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 ODHFCDMOIGN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3516070", Offset = "0x3514C70", VA = "0x183516070")]
	public KBJEGNAPODD(T1 OCDLKMLIIIG, T2 JJMOKOLGNGA, T3 KJAJIEBOOLH, T4 CIMGCANNBAJ, T5 FIEAPNJMIMN, T6 GGFLCDMFOKK, T7 EOAKKEADPHF, T8 NCNPFFHPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3515960", Offset = "0x3514560", VA = "0x183515960", Slot = "4")]
	public int CompareTo(global::KBJEGNAPODD<T1, T2, T3, T4, T5, T6, T7, T8> PJEOMNDGEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3515BB0", Offset = "0x35147B0", VA = "0x183515BB0", Slot = "0")]
	public override bool Equals(object PJEOMNDGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3515D70", Offset = "0x3514970", VA = "0x183515D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3515EE0", Offset = "0x3514AE0", VA = "0x183515EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
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
	public T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float EFKAOEFDDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1057C10", Offset = "0x1056810", VA = "0x181057C10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x40FDE10", Offset = "0x40FCA10", VA = "0x1840FDE10")]
	public T DBDFNLLBPLL(float NHMGOELDBCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x40FE070", Offset = "0x40FCC70", VA = "0x1840FE070")]
	public T LCCGBJBJPOL(float NHMGOELDBCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FJEPJJKDNOE(T DMGEENBOIFD, T CGDAAEMLLFJ, float NHMGOELDBCA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7F10", Offset = "0x4DA6B10", VA = "0x184DA7F10", Slot = "4")]
	protected override float FJEPJJKDNOE(float DMGEENBOIFD, float CGDAAEMLLFJ, float NHMGOELDBCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7F90", Offset = "0x4DA6B90", VA = "0x184DA7F90")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4DAC370", Offset = "0x4DAAF70", VA = "0x184DAC370", Slot = "4")]
	protected override Vector3 FJEPJJKDNOE(Vector3 DMGEENBOIFD, Vector3 CGDAAEMLLFJ, float NHMGOELDBCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4DAC430", Offset = "0x4DAB030", VA = "0x184DAC430")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA63C0", Offset = "0x4DA4FC0", VA = "0x184DA63C0", Slot = "4")]
	protected override Color FJEPJJKDNOE(Color DMGEENBOIFD, Color CGDAAEMLLFJ, float NHMGOELDBCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6410", Offset = "0x4DA5010", VA = "0x184DA6410")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DebuggerTypeProxy(typeof(global::LKCDPOBKLJC<>.IKLHGHJEKAN))]
[DefaultMember("Item")]
public sealed class LKCDPOBKLJC<T> : IDisposable, global::MHGBGOBEELI<T>, DECPADDDKEJ, global::HEKGLHFJNDH<T, global::LKCDPOBKLJC<T>.LMNJOFFEOIE>, global::JFFBOILDLAN<T>, global::MEMNGBPOBFA<T, global::LKCDPOBKLJC<T>.LMNJOFFEOIE>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, global::LKCDPOBKLJC<T>.LMNJOFFEOIE>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct LMNJOFFEOIE : DECPADDDKEJ, global::AHKNCHBFGKO<T>, global::CFCFNKLKBEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly global::LKCDPOBKLJC<T> KNLPHCAMKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int CDAILEHNLPC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int BPKHNEOEKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1D03B50", Offset = "0x1D02750", VA = "0x181D03B50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T PMDANPCIONM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2B2E250", Offset = "0x2B2CE50", VA = "0x182B2E250", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private T NBMKKINFGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DAF0", Offset = "0x2B2C6F0", VA = "0x182B2DAF0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DCF0", Offset = "0x2B2C8F0", VA = "0x182B2DCF0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DF00", Offset = "0x2B2CB00", VA = "0x182B2DF00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E140", Offset = "0x2B2CD40", VA = "0x182B2E140")]
		private LMNJOFFEOIE(global::LKCDPOBKLJC<T> MPDFMGGHMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x23BEA20", Offset = "0x23BD620", VA = "0x1823BEA20")]
		public static LMNJOFFEOIE GPPOAKIDPIM(global::LKCDPOBKLJC<T> MPDFMGGHMLI)
		{
			return default(LMNJOFFEOIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D990", Offset = "0x2B2C590", VA = "0x182B2D990", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x23BEB00", Offset = "0x23BD700", VA = "0x1823BEB00", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class IKLHGHJEKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly global::LKCDPOBKLJC<T> KNLPHCAMKPH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BPKHNEOEKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x22722A0", Offset = "0x2270EA0", VA = "0x1822722A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public T[] ALNDDFHCMDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B23490", Offset = "0x2B22090", VA = "0x182B23490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool DADHAMOCIEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2B233D0", Offset = "0x2B21FD0", VA = "0x182B233D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
		public IKLHGHJEKAN(global::LKCDPOBKLJC<T> MPDFMGGHMLI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CCHDJMMCINJ GCAPDEKAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] MENPOAODFFC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x55CCD0", Offset = "0x55B8D0", VA = "0x18055CCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA10", Offset = "0x5DC610", VA = "0x1805DDA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> ALNDDFHCMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B480", Offset = "0x2B2A080", VA = "0x182B2B480")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B930", Offset = "0x2B2A530", VA = "0x182B2B930")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A840", Offset = "0x2B29440", VA = "0x182B2A840")]
	public static global::LKCDPOBKLJC<T> GPPOAKIDPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AB70", Offset = "0x2B29770", VA = "0x182B2AB70")]
	public static global::LKCDPOBKLJC<T> JGPGOAFGONG(int HNBFBADKDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BD90", Offset = "0x2B2A990", VA = "0x182B2BD90")]
	private LKCDPOBKLJC(T[] NKMGONGJAML, int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A9C0", Offset = "0x2B295C0", VA = "0x182B2A9C0", Slot = "5")]
	public T HAFGJCEHJAL(int DAEOPGECNJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A7C0", Offset = "0x2B293C0", VA = "0x182B2A7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A1F0", Offset = "0x2B28DF0", VA = "0x182B2A1F0")]
	public void DNJODILJGAL(in T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A150", Offset = "0x2B28D50", VA = "0x182B2A150")]
	public void DDJBJFOMCJI(int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B29B70", Offset = "0x2B28770", VA = "0x182B29B70")]
	public void CEMAOIMDDHM(int BNLHOMCBDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A9F0", Offset = "0x2B295F0", VA = "0x182B2A9F0")]
	private void IFAFBMBKJFL(int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A980", Offset = "0x2B29580", VA = "0x182B2A980", Slot = "11")]
	public LMNJOFFEOIE GetEnumerator()
	{
		return default(LMNJOFFEOIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A0E0", Offset = "0x2B28CE0", VA = "0x182B2A0E0", Slot = "8")]
	private global::AHKNCHBFGKO<T> JPCOBBKBKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A0E0", Offset = "0x2B28CE0", VA = "0x182B2A0E0", Slot = "10")]
	private global::CFCFNKLKBEF<T> CNEADLCAMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A0E0", Offset = "0x2B28CE0", VA = "0x182B2A0E0", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A0E0", Offset = "0x2B28CE0", VA = "0x182B2A0E0", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EGNJDMAFGLK
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3BA0", Offset = "0x1DD27A0", VA = "0x181DD3BA0")]
	public static global::LKCDPOBKLJC<T> GPPOAKIDPIM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1599820", Offset = "0x1598420", VA = "0x181599820")]
	public static global::LKCDPOBKLJC<T> JGPGOAFGONG<T>(int HNBFBADKDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x279DC10", Offset = "0x279C810", VA = "0x18279DC10")]
	public static bool GKBOIJJBFCI<T>(this global::LKCDPOBKLJC<T> MPDFMGGHMLI, in T ODCJDJDBONO) where T : global::FPLOMAMAJGF<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FIHFGNIJNII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OFPJGNCHLGN>> BDBPLLPDDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int GKFNCANGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int HKOKCNBJGCC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8D4070", Offset = "0x8D2C70", VA = "0x1808D4070")]
	private FIHFGNIJNII(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OFPJGNCHLGN>> JMMIBGMODOK, int AGKLLBFDKBF, int CCOPGLCNAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6E50", Offset = "0x4DA5A50", VA = "0x184DA6E50")]
	public static FIHFGNIJNII GPPOAKIDPIM()
	{
		return default(FIHFGNIJNII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6F80", Offset = "0x4DA5B80", VA = "0x184DA6F80")]
	public (int, int, Task) LEFOOJFKBLO(int DEGGBBOKGLD)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6ED0", Offset = "0x4DA5AD0", VA = "0x184DA6ED0")]
	public void IINFIFEMPGF(int DEGGBBOKGLD, int CCOPGLCNAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class ABHHMEGLPFD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TKey, TVal> KFMAHCKDFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Dictionary<TVal, TKey> EFOMOPIJOGH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x22722A0", Offset = "0x2270EA0", VA = "0x1822722A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FGJLGJIJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TKey> AMNOMAFPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x22759C0", Offset = "0x22745C0", VA = "0x1822759C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ICollection<TVal> DDLAPBMKIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x22754E0", Offset = "0x22740E0", VA = "0x1822754E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TVal ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x25889E0", Offset = "0x25875E0", VA = "0x1825889E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x226E2C0", Offset = "0x226CEC0", VA = "0x18226E2C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TKey ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4222A90", Offset = "0x4221690", VA = "0x184222A90")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4222C10", Offset = "0x4221810", VA = "0x184222C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x42226C0", Offset = "0x42212C0", VA = "0x1842226C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4222CB0", Offset = "0x42218B0", VA = "0x184222CB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD42C0", Offset = "0x2BD2EC0", VA = "0x182BD42C0", Slot = "9")]
	public void Add(TKey OMAJLLKKGPH, TVal ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4222250", Offset = "0x4220E50", VA = "0x184222250", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3293A90", Offset = "0x3292690", VA = "0x183293A90", Slot = "8")]
	public bool ContainsKey(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DEE0", Offset = "0x2E7CAE0", VA = "0x182E7DEE0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A9C0", Offset = "0x2B295C0", VA = "0x182B2A9C0", Slot = "10")]
	public bool Remove(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A9C0", Offset = "0x2B295C0", VA = "0x182B2A9C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2272140", Offset = "0x2270D40", VA = "0x182272140", Slot = "11")]
	public bool TryGetValue(TKey OMAJLLKKGPH, out TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x42228D0", Offset = "0x42214D0", VA = "0x1842228D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4222750", Offset = "0x4221350", VA = "0x184222750", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IIIEKHDFIBE, int ALPKDHKFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x42227B0", Offset = "0x42213B0", VA = "0x1842227B0")]
	public void DNJODILJGAL(TVal IFJECFHDAOK, TKey OMAJLLKKGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4222830", Offset = "0x4221430", VA = "0x184222830")]
	public void DNJODILJGAL(KeyValuePair<TVal, TKey> DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4222C50", Offset = "0x4221850", VA = "0x184222C50")]
	public bool PMCGIMHJPDO(TVal OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2264950", Offset = "0x2263550", VA = "0x182264950")]
	public bool FLMNDNPBPEH(KeyValuePair<TVal, TKey> DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x20CC4C0", Offset = "0x20CB0C0", VA = "0x1820CC4C0")]
	public bool JGCOEHFAOLL(TVal OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20CC4C0", Offset = "0x20CB0C0", VA = "0x1820CC4C0")]
	public bool JGCOEHFAOLL(KeyValuePair<TVal, TKey> DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4222280", Offset = "0x4220E80", VA = "0x184222280")]
	public bool BOKJIEDKGMF(TVal OMAJLLKKGPH, out TKey ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4222AC0", Offset = "0x42216C0", VA = "0x184222AC0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> PELBEPBEGHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4222640", Offset = "0x4221240", VA = "0x184222640")]
	private void CMHGDACEEOL(TKey OMAJLLKKGPH, TVal IFJECFHDAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x42229E0", Offset = "0x42215E0", VA = "0x1842229E0")]
	private void HMFPEIMAFFG(TKey OMAJLLKKGPH, TVal IFJECFHDAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x42224F0", Offset = "0x42210F0", VA = "0x1842224F0")]
	private bool CCMNJANAICA(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4222430", Offset = "0x4221030", VA = "0x184222430")]
	private bool CCMNJANAICA(TVal IFJECFHDAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4222D50", Offset = "0x4221950", VA = "0x184222D50")]
	public ABHHMEGLPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class GGAAJNBOKJM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private global::GGAAJNBOKJM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xFFD4F0", Offset = "0xFFC0F0", VA = "0x180FFD4F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3837350", Offset = "0x3835F50", VA = "0x183837350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3837710", Offset = "0x3836310", VA = "0x183837710")]
		public Enumerator(global::GGAAJNBOKJM<T> EINFEEMFPOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3836D20", Offset = "0x3835920", VA = "0x183836D20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3837110", Offset = "0x3835D10", VA = "0x183837110", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x38369E0", Offset = "0x38355E0", VA = "0x1838369E0")]
		private void JNIHNLBFCAG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private T[] HLBDBDEKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int NAIHDOIDODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int EGDPDCHLNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int BEDKPKPHEKA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3845020", Offset = "0x3843C20", VA = "0x183845020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3845DC0", Offset = "0x38449C0", VA = "0x183845DC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3846CA0", Offset = "0x38458A0", VA = "0x183846CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3847080", Offset = "0x3845C80", VA = "0x183847080")]
	public GGAAJNBOKJM(int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3845A20", Offset = "0x3844620", VA = "0x183845A20")]
	public void DNJODILJGAL(T NHMGOELDBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3846670", Offset = "0x3845270", VA = "0x183846670")]
	public void LCJMEAEDFMB(IEnumerable<T> PANEINNCMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3845000", Offset = "0x3843C00", VA = "0x183845000")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3845CE0", Offset = "0x38448E0", VA = "0x183845CE0")]
	public void JBBIAGFMOHE(int MAKGNGIINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3845C50", Offset = "0x3844850", VA = "0x183845C50")]
	public void FPMAHBDLGJM(int MAKGNGIINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38451B0", Offset = "0x3843DB0", VA = "0x1838451B0")]
	public void CFHMDJGKEDJ(T[] IIIEKHDFIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3845F60", Offset = "0x3844B60", VA = "0x183845F60")]
	public Enumerator LALDOHEBOCO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3846F30", Offset = "0x3845B30", VA = "0x183846F30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3846F30", Offset = "0x3845B30", VA = "0x183846F30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3845780", Offset = "0x3844380", VA = "0x183845780")]
	private int CHIIEMKAPBE(int PMMFOLCEJEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3846C70", Offset = "0x3845870", VA = "0x183846C70")]
	private int LMCFOPKKJCL(int PMMFOLCEJEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EFGJOGPEDBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IDisposable[] MENPOAODFFC;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67A640", Offset = "0x679240", VA = "0x18067A640")]
	public EFGJOGPEDBP(params IDisposable[] NKMGONGJAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xCCB340", Offset = "0xCC9F40", VA = "0x180CCB340")]
	public static EFGJOGPEDBP GPPOAKIDPIM(params IDisposable[] NKMGONGJAML)
	{
		return default(EFGJOGPEDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4DA68A0", Offset = "0x4DA54A0", VA = "0x184DA68A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LPCJDJMFIFH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IDisposable ELBDHDPLDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public T HNBDKKLMMPE;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x258A000", Offset = "0x2588C00", VA = "0x18258A000")]
	public LPCJDJMFIFH(IDisposable FGMFLLPICOA, in T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0490", Offset = "0x1DDF090", VA = "0x181DE0490")]
	public static global::LPCJDJMFIFH<U> GIIHNIHAAAH<U>(in global::LPCJDJMFIFH<T> FGMFLLPICOA, in U ODCJDJDBONO)
	{
		return default(global::LPCJDJMFIFH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1DE04D0", Offset = "0x1DDF0D0", VA = "0x181DE04D0")]
	public global::LPCJDJMFIFH<U> LEFPLLKEOCI<U>(in U ODCJDJDBONO)
	{
		return default(global::LPCJDJMFIFH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0500", Offset = "0x1DDF100", VA = "0x181DE0500")]
	public static global::LPCJDJMFIFH<(T, U)> OGHIKEDADBH<U>(in global::LPCJDJMFIFH<T> BDJKEBGEAJO, in global::LPCJDJMFIFH<U> GONCOEMNHPC)
	{
		return default(global::LPCJDJMFIFH<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2B30360", Offset = "0x2B2EF60", VA = "0x182B30360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NJANJIBKFAP
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3D70", Offset = "0x1DE2970", VA = "0x181DE3D70")]
	public static global::LPCJDJMFIFH<T> GPPOAKIDPIM<T>(IDisposable FGMFLLPICOA, in T ODCJDJDBONO)
	{
		return default(global::LPCJDJMFIFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE04D0", Offset = "0x1DDF0D0", VA = "0x181DE04D0")]
	public static global::LPCJDJMFIFH<U> GIIHNIHAAAH<U, T>(in global::LPCJDJMFIFH<T> IDINGPAEBKH, in U ODCJDJDBONO)
	{
		return default(global::LPCJDJMFIFH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3DC0", Offset = "0x1DE29C0", VA = "0x181DE3DC0")]
	public static global::LPCJDJMFIFH<(T, U)> OGHIKEDADBH<T, U>(in global::LPCJDJMFIFH<T> BDJKEBGEAJO, in global::LPCJDJMFIFH<U> GONCOEMNHPC)
	{
		return default(global::LPCJDJMFIFH<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct CCHDJMMCINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0")]
	public static CCHDJMMCINJ COEJANPDELD<T>([Optional] string IEMBGPCJHKP, [Optional] string KOMILMOMAHB, bool ADEKFPNCCMH = false)
	{
		return default(CCHDJMMCINJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public readonly struct ABCHEOPDBIL<T> : global::MEMNGBPOBFA<T, global::ABCHEOPDBIL<T>.DOCLGDPPBOA>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, global::ABCHEOPDBIL<T>.DOCLGDPPBOA>, IEnumerable<T>, IEnumerable, global::MHGBGOBEELI<T>, DECPADDDKEJ
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct DOCLGDPPBOA : DECPADDDKEJ, global::CFCFNKLKBEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly T[] KNLPHCAMKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int CDAILEHNLPC;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BPKHNEOEKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x222EF30", Offset = "0x222DB30", VA = "0x18222EF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public T PMDANPCIONM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB60", Offset = "0x23BD760", VA = "0x1823BEB60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB10", Offset = "0x23BD710", VA = "0x1823BEB10", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB10", Offset = "0x23BD710", VA = "0x1823BEB10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7A79C0", Offset = "0x7A65C0", VA = "0x1807A79C0")]
		private DOCLGDPPBOA(T[] MPDFMGGHMLI, int PMMFOLCEJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x23BEA20", Offset = "0x23BD620", VA = "0x1823BEA20")]
		public static DOCLGDPPBOA GPPOAKIDPIM(T[] MPDFMGGHMLI)
		{
			return default(DOCLGDPPBOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x23BEA80", Offset = "0x23BD680", VA = "0x1823BEA80", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x23BEB00", Offset = "0x23BD700", VA = "0x1823BEB00", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly T[] IDPIIAMFLMH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int OMJEPJJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x222EF30", Offset = "0x222DB30", VA = "0x18222EF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x23CAE90", Offset = "0x23C9A90", VA = "0x1823CAE90", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x23CB0D0", Offset = "0x23C9CD0", VA = "0x1823CB0D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67A640", Offset = "0x679240", VA = "0x18067A640")]
	internal ABCHEOPDBIL(T[] IIIEKHDFIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x23CB070", Offset = "0x23C9C70", VA = "0x1823CB070", Slot = "9")]
	public T HAFGJCEHJAL(int PMMFOLCEJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4222180", Offset = "0x4220D80", VA = "0x184222180", Slot = "6")]
	public DOCLGDPPBOA GetEnumerator()
	{
		return default(DOCLGDPPBOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4222080", Offset = "0x4220C80", VA = "0x184222080", Slot = "5")]
	private global::CFCFNKLKBEF<T> CNEADLCAMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4222080", Offset = "0x4220C80", VA = "0x184222080", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4222080", Offset = "0x4220C80", VA = "0x184222080", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OGPIOMBALKA
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCA10", Offset = "0x1CCB610", VA = "0x181CCCA10")]
	public static global::ABCHEOPDBIL<T> GPPOAKIDPIM<T>(T[] IIIEKHDFIBE)
	{
		return default(global::ABCHEOPDBIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCA40", Offset = "0x1CCB640", VA = "0x181CCCA40")]
	public static global::ABCHEOPDBIL<T> PGBMEHBJKCG<T>()
	{
		return default(global::ABCHEOPDBIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1599820", Offset = "0x1598420", VA = "0x181599820")]
	public static global::ABCHEOPDBIL<T> KGNIOIMAHMG<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::ABCHEOPDBIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC9E0", Offset = "0x1CCB5E0", VA = "0x181CCC9E0")]
	public static global::ABCHEOPDBIL<T>.DOCLGDPPBOA FNKKFMPCKEI<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::ABCHEOPDBIL<T>.DOCLGDPPBOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1599820", Offset = "0x1598420", VA = "0x181599820")]
	public static global::ABCHEOPDBIL<T> AMEHIHDEKIM<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::ABCHEOPDBIL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct AAAGCPDGNCN<T, U> : global::MEMNGBPOBFA<T, U>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, U>, IEnumerable<T>, IEnumerable where U : global::CFCFNKLKBEF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly U BNEGLCPCOCD;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2B24D20", Offset = "0x2B23920", VA = "0x182B24D20")]
	internal AAAGCPDGNCN(in U IJJJPNLBANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x865D30", Offset = "0x864930", VA = "0x180865D30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "5")]
	private global::CFCFNKLKBEF<T> CNEADLCAMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EFGKGBKDMHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB520", Offset = "0x1CCA120", VA = "0x181CCB520")]
	public static global::AAAGCPDGNCN<T, U> GPPOAKIDPIM<U>(in U IJJJPNLBANO) where U : global::CFCFNKLKBEF<T>
	{
		return default(global::AAAGCPDGNCN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EMAFIGADFDG<TResult, TResultEnumerator> where TResultEnumerator : global::CFCFNKLKBEF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC4B0", Offset = "0x1CCB0B0", VA = "0x181CCC4B0")]
	public static global::KIKEALOFHML<TSourceEnumerator, TResultEnumerator, TResult> FNACCICOBFN<TSourceEnumerator>(in TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::KIKEALOFHML<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KIKEALOFHML<TSourceEnumerator, TResultEnumerator, TResult> : global::CFCFNKLKBEF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::CFCFNKLKBEF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private TSourceEnumerator KNLPHCAMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private TResultEnumerator NOHLDHEDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool KAJDKADELJL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public TResult PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x23CAE20", Offset = "0x23C9A20", VA = "0x1823CAE20", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x23CAD40", Offset = "0x23C9940", VA = "0x1823CAD40", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x23CAD40", Offset = "0x23C9940", VA = "0x1823CAD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x23CADD0", Offset = "0x23C99D0", VA = "0x1823CADD0")]
	internal KIKEALOFHML(in TSourceEnumerator MPDFMGGHMLI, in TResultEnumerator AOKFKPOBLCC, bool GIANOLEFCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x23CABC0", Offset = "0x23C97C0", VA = "0x1823CABC0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x23CACF0", Offset = "0x23C98F0", VA = "0x1823CACF0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x23CAB70", Offset = "0x23C9770", VA = "0x1823CAB70", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CMAEBEMALEP<TSourceEnumerator, TSource, TResult> : DECPADDDKEJ, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DECPADDDKEJ, global::CFCFNKLKBEF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator KNLPHCAMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly global::PDBLCCHDNFF<TSource, TResult> CGLHFJKCIIG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0AE0", Offset = "0x2FDF6E0", VA = "0x182FE0AE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TResult PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2FE17F0", Offset = "0x2FE03F0", VA = "0x182FE17F0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1420", Offset = "0x2FE0020", VA = "0x182FE1420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2373C80", Offset = "0x2372880", VA = "0x182373C80")]
	internal CMAEBEMALEP(in TSourceEnumerator MPDFMGGHMLI, global::PDBLCCHDNFF<TSource, TResult> IEJMKJOOOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2FE0F40", Offset = "0x2FDFB40", VA = "0x182FE0F40", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2FE1170", Offset = "0x2FDFD70", VA = "0x182FE1170", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE0D60", Offset = "0x2FDF960", VA = "0x182FE0D60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BLKCKDNMOBC<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::CFCFNKLKBEF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::CFCFNKLKBEF<TSource> where TResultEnumerator : global::CFCFNKLKBEF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private TSourceEnumerator KNLPHCAMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TResultEnumerator NOHLDHEDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::PDBLCCHDNFF<TSource, TResultEnumerator> CGLHFJKCIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool KAJDKADELJL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x23CAE20", Offset = "0x23C9A20", VA = "0x1823CAE20", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x23CAD40", Offset = "0x23C9940", VA = "0x1823CAD40", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x23CAD40", Offset = "0x23C9940", VA = "0x1823CAD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3900740", Offset = "0x38FF340", VA = "0x183900740")]
	internal BLKCKDNMOBC(in TSourceEnumerator MPDFMGGHMLI, in TResultEnumerator AOKFKPOBLCC, global::PDBLCCHDNFF<TSource, TResultEnumerator> IEJMKJOOOOB, bool GIANOLEFCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3900560", Offset = "0x38FF160", VA = "0x183900560", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x39006F0", Offset = "0x38FF2F0", VA = "0x1839006F0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3900510", Offset = "0x38FF110", VA = "0x183900510", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HPFJPNCIMDD<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : DECPADDDKEJ, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : DECPADDDKEJ, global::CFCFNKLKBEF<TSource1> where TSource2Enumerator : DECPADDDKEJ, global::CFCFNKLKBEF<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TSource1Enumerator AFAGHECHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private TSource2Enumerator OEAIFDKHEJN;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3792270", Offset = "0x3790E70", VA = "0x183792270", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (TSource1, TSource2) PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x37924F0", Offset = "0x37910F0", VA = "0x1837924F0", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3792450", Offset = "0x3791050", VA = "0x183792450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x321B6A0", Offset = "0x321A2A0", VA = "0x18321B6A0")]
	internal HPFJPNCIMDD(in TSource1Enumerator MKJFNIMEMBK, in TSource2Enumerator DGPJLEBMADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3792370", Offset = "0x3790F70", VA = "0x183792370", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x37923E0", Offset = "0x3790FE0", VA = "0x1837923E0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3792310", Offset = "0x3790F10", VA = "0x183792310", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JGJPFIBALBF<T, U> : global::GMKBFJKHBBK<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly U BNEGLCPCOCD;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x31DEA00", Offset = "0x31DD600", VA = "0x1831DEA00")]
	internal JGJPFIBALBF(in U IJJJPNLBANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x33E3100", Offset = "0x33E1D00", VA = "0x1833E3100", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x33E3100", Offset = "0x33E1D00", VA = "0x1833E3100", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BNHABDOCKHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB4E0", Offset = "0x1CCA0E0", VA = "0x181CCB4E0")]
	public static global::JGJPFIBALBF<T, U> GPPOAKIDPIM<U>(in U IJJJPNLBANO) where U : IEnumerator<T>
	{
		return default(global::JGJPFIBALBF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JONPNALCGGP<TSourceEnumerator, TSource, TResult> : DECPADDDKEJ, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DECPADDDKEJ, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSourceEnumerator KNLPHCAMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Func<TSource, TResult> CGLHFJKCIIG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3514D30", Offset = "0x3513930", VA = "0x183514D30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public TResult PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3514F10", Offset = "0x3513B10", VA = "0x183514F10", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3514ED0", Offset = "0x3513AD0", VA = "0x183514ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2FE14E0", Offset = "0x2FE00E0", VA = "0x182FE14E0")]
	internal JONPNALCGGP(in TSourceEnumerator MPDFMGGHMLI, Func<TSource, TResult> IEJMKJOOOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3514E30", Offset = "0x3513A30", VA = "0x183514E30", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3514E80", Offset = "0x3513A80", VA = "0x183514E80", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3514DE0", Offset = "0x35139E0", VA = "0x183514DE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class HEMDGDCPBNA
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x279F4F0", Offset = "0x279E0F0", VA = "0x18279F4F0")]
	public static bool OIADACPCCFB<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator MPDFMGGHMLI, in TArgs JCPCHHDMGJM, in global::DDMGCOFGHKI<TArgs, TSource, bool> GGNNGDCPHON) where TSourceEnumerator : global::CFCFNKLKBEF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1F42F60", Offset = "0x1F41B60", VA = "0x181F42F60")]
	public static int CNNBONMCIKD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator MPDFMGGHMLI, in TArgs JCPCHHDMGJM, global::DDMGCOFGHKI<TArgs, TSource, bool> GGNNGDCPHON) where TSourceEnumerator : global::CFCFNKLKBEF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x279F3A0", Offset = "0x279DFA0", VA = "0x18279F3A0")]
	public static bool JCOJNPKOPNN<TSourceEnumerator, TSource>(this TSourceEnumerator MPDFMGGHMLI, in TSource DDINDLBJKFG) where TSourceEnumerator : global::CFCFNKLKBEF<TSource> where TSource : global::FPLOMAMAJGF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1F43250", Offset = "0x1F41E50", VA = "0x181F43250")]
	public static int PJPBJAJJCNM<TSourceEnumerator, TSource>(this TSourceEnumerator MPDFMGGHMLI, in TSource ODCJDJDBONO) where TSourceEnumerator : global::CFCFNKLKBEF<TSource> where TSource : global::FPLOMAMAJGF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x20FAB40", Offset = "0x20F9740", VA = "0x1820FAB40")]
	public static global::CMAEBEMALEP<TSourceEnumerator, TSource, TResult> KMBCNBLLIIF<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator MPDFMGGHMLI, global::PDBLCCHDNFF<TSource, TResult> IEJMKJOOOOB) where TSourceEnumerator : DECPADDDKEJ, global::CFCFNKLKBEF<TSource>
	{
		return default(global::CMAEBEMALEP<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0240", Offset = "0x1CCEE40", VA = "0x181CD0240")]
	public static global::JONPNALCGGP<TSourceEnumerator, TSource, TResult> ABOHBONLBAL<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator MPDFMGGHMLI, Func<TSource, TResult> IEJMKJOOOOB) where TSourceEnumerator : DECPADDDKEJ, IEnumerator<TSource>
	{
		return default(global::JONPNALCGGP<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FAHBLGGABPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x279E900", Offset = "0x279D500", VA = "0x18279E900")]
	public static bool NCDAONFGLAK<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1596440", Offset = "0x1595040", VA = "0x181596440")]
	public static T NFMAOMODLPC<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : global::CFCFNKLKBEF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x20FA6F0", Offset = "0x20F92F0", VA = "0x1820FA6F0")]
	public static global::BLKCKDNMOBC<TSourceEnumerator, TSource, TResultEnumerator, T> NBINLALHDBB<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator MPDFMGGHMLI, global::PDBLCCHDNFF<TSource, TResultEnumerator> IEJMKJOOOOB) where TSourceEnumerator : global::CFCFNKLKBEF<TSource> where TResultEnumerator : global::CFCFNKLKBEF<T>
	{
		return default(global::BLKCKDNMOBC<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x21E3320", Offset = "0x21E1F20", VA = "0x1821E3320")]
	public static string GEIANAIDFBG<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x306BA20", Offset = "0x306A620", VA = "0x18306BA20")]
	public static T[] NJGCNCEIBAJ<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : DECPADDDKEJ, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D050", Offset = "0x1F2BC50", VA = "0x181F2D050")]
	public static T DLPDHIHIFDM<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x279E7D0", Offset = "0x279D3D0", VA = "0x18279E7D0")]
	public static bool FKCHDDCIFAK<TSourceEnumerator>(TSourceEnumerator MPDFMGGHMLI) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CNGJMEIPHMG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB940", Offset = "0x1CCA540", VA = "0x181CCB940")]
	public static global::HPFJPNCIMDD<TSource1Enumerator, T, TSource2Enumerator, U> MNFDNKKINIH<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator MKJFNIMEMBK, in TSource2Enumerator DGPJLEBMADA) where TSource1Enumerator : DECPADDDKEJ, global::CFCFNKLKBEF<T> where TSource2Enumerator : DECPADDDKEJ, global::CFCFNKLKBEF<U>
	{
		return default(global::HPFJPNCIMDD<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CBNELKDEPCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CFCFNKLKBEF<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MEMNGBPOBFA<T, TEnumerator> : global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::CFCFNKLKBEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CFCFNKLKBEF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	T PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MHGBGOBEELI<T> : DECPADDDKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HAFGJCEHJAL(int DAEOPGECNJN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GMKBFJKHBBK<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DECPADDDKEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FPLOMAMAJGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEGDFDJGBGH(in T PJEOMNDGEFC);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface JFFBOILDLAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AHKNCHBFGKO<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface HEKGLHFJNDH<T, TEnumerator> : global::JFFBOILDLAN<T>, global::MEMNGBPOBFA<T, TEnumerator>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::AHKNCHBFGKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface AHKNCHBFGKO<T> : global::CFCFNKLKBEF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	new T PMDANPCIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public delegate void CCJJKKLGGPA<T>(in T CEBMIJKEKIC);
[Cpp2IlInjected.Token(Token = "0x2000047")]
public delegate void NGBJNGOGNHL<T1, T2>(in T1 IDDOADLCPDE, in T2 EHCBPBMHDLI);
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NDLGOGNOPKN
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x20EDF90", Offset = "0x20ECB90", VA = "0x1820EDF90")]
	public static bool ECDLFNGOGKE<T, U>(this T MPDFMGGHMLI, in U NJBMHJCLPCJ) where T : global::FPLOMAMAJGF<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate TResult PDBLCCHDNFF<T, out TResult>(in T CEBMIJKEKIC);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate TResult DDMGCOFGHKI<T1, T2, out TResult>(in T1 IDDOADLCPDE, in T2 EHCBPBMHDLI);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public delegate TResult KALBEJJLLFB<T1, T2, T3, out TResult>(in T1 IDDOADLCPDE, in T2 EHCBPBMHDLI, in T3 HEKCLICLLOI);
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult JMNOEBBKIAF<T, TResult>(in T CEBMIJKEKIC);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult BKJPLJDKJFP<T1, T2, TResult>(in T1 IDDOADLCPDE, in T2 EHCBPBMHDLI);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult AAMEELIEBDJ<T1, T2, T3, TResult>(in T1 IDDOADLCPDE, in T2 EHCBPBMHDLI, in T3 HEKCLICLLOI);
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public struct KJEBJKLBNHM<T> : global::HEKGLHFJNDH<T, global::KJEBJKLBNHM<T>.ABAKPPOCDGD>, global::JFFBOILDLAN<T>, global::MEMNGBPOBFA<T, global::KJEBJKLBNHM<T>.ABAKPPOCDGD>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, global::KJEBJKLBNHM<T>.ABAKPPOCDGD>, IEnumerable<T>, IEnumerable, global::MHGBGOBEELI<T>, DECPADDDKEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct ABAKPPOCDGD : DECPADDDKEJ, global::AHKNCHBFGKO<T>, global::CFCFNKLKBEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private T[] KNLPHCAMKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int CDAILEHNLPC;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int BPKHNEOEKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x222EF30", Offset = "0x222DB30", VA = "0x18222EF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public T PMDANPCIONM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB60", Offset = "0x23BD760", VA = "0x1823BEB60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private T NBMKKINFGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x23BEAB0", Offset = "0x23BD6B0", VA = "0x1823BEAB0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB10", Offset = "0x23BD710", VA = "0x1823BEB10", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x23BEB10", Offset = "0x23BD710", VA = "0x1823BEB10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A79C0", Offset = "0x7A65C0", VA = "0x1807A79C0")]
		private ABAKPPOCDGD(T[] MPDFMGGHMLI, int PMMFOLCEJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x23BEA20", Offset = "0x23BD620", VA = "0x1823BEA20")]
		public static ABAKPPOCDGD GPPOAKIDPIM(T[] MPDFMGGHMLI)
		{
			return default(ABAKPPOCDGD);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x23BEA80", Offset = "0x23BD680", VA = "0x1823BEA80", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x23BEB00", Offset = "0x23BD700", VA = "0x1823BEB00", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private T[] IDPIIAMFLMH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int OMJEPJJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x222EF30", Offset = "0x222DB30", VA = "0x18222EF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x23CAE90", Offset = "0x23C9A90", VA = "0x1823CAE90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x23CB0D0", Offset = "0x23C9CD0", VA = "0x1823CB0D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67A640", Offset = "0x679240", VA = "0x18067A640")]
	internal KJEBJKLBNHM(T[] IIIEKHDFIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x23CB070", Offset = "0x23C9C70", VA = "0x1823CB070", Slot = "11")]
	public T HAFGJCEHJAL(int PMMFOLCEJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x23CB110", Offset = "0x23C9D10", VA = "0x1823CB110")]
	public global::ABCHEOPDBIL<T> LJMBIPAEPFO()
	{
		return default(global::ABCHEOPDBIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x23CAFD0", Offset = "0x23C9BD0", VA = "0x1823CAFD0", Slot = "8")]
	public ABAKPPOCDGD GetEnumerator()
	{
		return default(ABAKPPOCDGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x23CAED0", Offset = "0x23C9AD0", VA = "0x1823CAED0", Slot = "5")]
	private global::AHKNCHBFGKO<T> JPCOBBKBKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x23CAED0", Offset = "0x23C9AD0", VA = "0x1823CAED0", Slot = "7")]
	private global::CFCFNKLKBEF<T> CNEADLCAMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x23CAED0", Offset = "0x23C9AD0", VA = "0x1823CAED0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x23CAED0", Offset = "0x23C9AD0", VA = "0x1823CAED0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FLJOMFKDHHB
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCA10", Offset = "0x1CCB610", VA = "0x181CCCA10")]
	public static global::KJEBJKLBNHM<T> GPPOAKIDPIM<T>(T[] IIIEKHDFIBE)
	{
		return default(global::KJEBJKLBNHM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCA40", Offset = "0x1CCB640", VA = "0x181CCCA40")]
	public static global::KJEBJKLBNHM<T> PGBMEHBJKCG<T>()
	{
		return default(global::KJEBJKLBNHM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1599820", Offset = "0x1598420", VA = "0x181599820")]
	public static global::KJEBJKLBNHM<T> DLMMNEHJPBB<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::KJEBJKLBNHM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC9E0", Offset = "0x1CCB5E0", VA = "0x181CCC9E0")]
	public static global::KJEBJKLBNHM<T>.ABAKPPOCDGD EIDFEIKPNII<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::KJEBJKLBNHM<T>.ABAKPPOCDGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1599820", Offset = "0x1598420", VA = "0x181599820")]
	public static global::KJEBJKLBNHM<T> KGAALNMGDFE<T>(this T[] MPDFMGGHMLI)
	{
		return default(global::KJEBJKLBNHM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct LIDHOFBLKND<T, U> : global::HEKGLHFJNDH<T, U>, global::JFFBOILDLAN<T>, global::MEMNGBPOBFA<T, U>, global::CBNELKDEPCJ<T>, global::GMKBFJKHBBK<T, U>, IEnumerable<T>, IEnumerable where U : global::AHKNCHBFGKO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly U BNEGLCPCOCD;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B24D20", Offset = "0x2B23920", VA = "0x182B24D20")]
	internal LIDHOFBLKND(in U IJJJPNLBANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x865D30", Offset = "0x864930", VA = "0x180865D30", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "5")]
	private global::AHKNCHBFGKO<T> JPCOBBKBKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "7")]
	private global::CFCFNKLKBEF<T> CNEADLCAMDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B24CF0", Offset = "0x2B238F0", VA = "0x182B24CF0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HLFILKGFHGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB520", Offset = "0x1CCA120", VA = "0x181CCB520")]
	public static global::LIDHOFBLKND<T, U> GPPOAKIDPIM<U>(in U IJJJPNLBANO) where U : global::AHKNCHBFGKO<T>
	{
		return default(global::LIDHOFBLKND<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class MFMENGAKLPF<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<Internal, External> GMPPNDLOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Func<External, Internal> MNDOBDNDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IList<Internal> OBBDHGFOJGA;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IList<Internal> AFGGCCBECNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FGJLGJIJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DD990", Offset = "0x5DC590", VA = "0x1805DD990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6CECC0", Offset = "0x6CD8C0", VA = "0x1806CECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public External ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x258BDC0", Offset = "0x258A9C0", VA = "0x18258BDC0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x258BE60", Offset = "0x258AA60", VA = "0x18258BE60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x258BD60", Offset = "0x258A960", VA = "0x18258BD60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x258BCD0", Offset = "0x258A8D0", VA = "0x18258BCD0")]
	public MFMENGAKLPF(Func<Internal, External> GMPPNDLOFIK, Func<External, Internal> MNDOBDNDKOF, bool LHJFIENBLBB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x258B9E0", Offset = "0x258A5E0", VA = "0x18258B9E0", Slot = "6")]
	public int IndexOf(External DDINDLBJKFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x258B660", Offset = "0x258A260", VA = "0x18258B660", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x258B6C0", Offset = "0x258A2C0", VA = "0x18258B6C0", Slot = "13")]
	public bool Contains(External DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x258B750", Offset = "0x258A350", VA = "0x18258B750", Slot = "14")]
	public void CopyTo(External[] IIIEKHDFIBE, int ALPKDHKFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x258B570", Offset = "0x258A170", VA = "0x18258B570", Slot = "11")]
	public void Add(External DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x258BAD0", Offset = "0x258A6D0", VA = "0x18258BAD0", Slot = "7")]
	public void Insert(int PMMFOLCEJEJ, External DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x258BC40", Offset = "0x258A840", VA = "0x18258BC40", Slot = "15")]
	public bool Remove(External DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x258BB70", Offset = "0x258A770", VA = "0x18258BB70", Slot = "8")]
	public void RemoveAt(int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x258B970", Offset = "0x258A570", VA = "0x18258B970", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EF50F0", Offset = "0x1EF3CF0", VA = "0x181EF50F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DefaultMember("Item")]
public class NAFACGBENKD<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<Internal, External> GMPPNDLOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IReadOnlyList<Internal> OBBDHGFOJGA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<Internal> AFGGCCBECNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FGJLGJIJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x55CFE0", Offset = "0x55BBE0", VA = "0x18055CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public External ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x31D20C0", Offset = "0x31D0CC0", VA = "0x1831D20C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x31D2060", Offset = "0x31D0C60", VA = "0x1831D2060", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
	public NAFACGBENKD(Func<Internal, External> GMPPNDLOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x31D2010", Offset = "0x31D0C10", VA = "0x1831D2010")]
	public NAFACGBENKD(IReadOnlyList<Internal> OBBDHGFOJGA, Func<Internal, External> GMPPNDLOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D80", Offset = "0x31D0980", VA = "0x1831D1D80")]
	public void CFHMDJGKEDJ(External[] IIIEKHDFIBE, int ALPKDHKFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x31D1FA0", Offset = "0x31D0BA0", VA = "0x1831D1FA0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1D7EDD0", Offset = "0x1D7D9D0", VA = "0x181D7EDD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public class CECBGLNPDJM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IReadOnlyList<Internal> OBBDHGFOJGA;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public IReadOnlyList<Internal> AFGGCCBECNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FGJLGJIJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x55CFE0", Offset = "0x55BBE0", VA = "0x18055CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public External ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E847D0", Offset = "0x2E833D0", VA = "0x182E847D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E84770", Offset = "0x2E83370", VA = "0x182E84770", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
	public CECBGLNPDJM(IReadOnlyList<Internal> OBBDHGFOJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E84660", Offset = "0x2E83260", VA = "0x182E84660")]
	public bool FLMNDNPBPEH(External DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E84430", Offset = "0x2E83030", VA = "0x182E84430")]
	public void CFHMDJGKEDJ(External[] IIIEKHDFIBE, int ALPKDHKFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E84700", Offset = "0x2E83300", VA = "0x182E84700", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF50F0", Offset = "0x1EF3CF0", VA = "0x181EF50F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class LECFJNFPGFK
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FLCDOMODLMC(object[] JCPCHHDMGJM);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	protected LECFJNFPGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class JBJECBPLCEI<T> : LECFJNFPGFK
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	protected struct GHOEMDKKHPM
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum ONLDBDCKKHM
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public ONLDBDCKKHM CEEEOOFNMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public T EMKOBNDJJHF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private int BPOPNONCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly bool BKHPCHGPACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	protected readonly bool EKJLDKOMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	protected List<T> EMDBEKFBDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private List<GHOEMDKKHPM> AKFBLMAANKN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool JFPHPGAMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x33E12C0", Offset = "0x33DFEC0", VA = "0x1833E12C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x33E1790", Offset = "0x33E0390", VA = "0x1833E1790")]
	protected JBJECBPLCEI(bool EKJLDKOMGGB, bool BKHPCHGPACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x33E1300", Offset = "0x33DFF00", VA = "0x1833E1300")]
	protected bool JABOKBMPGJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x33E1500", Offset = "0x33E0100", VA = "0x1833E1500")]
	protected void JOAPIKNHGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x33E15E0", Offset = "0x33E01E0", VA = "0x1833E15E0")]
	protected void NDJGDABBDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2448230", Offset = "0x2446E30", VA = "0x182448230")]
	private static void LEDBPANJCJH<U>(ref List<U> OBBDHGFOJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x33E1140", Offset = "0x33DFD40", VA = "0x1833E1140", Slot = "5")]
	public void DNJODILJGAL(T EMKOBNDJJHF, bool ICEMCBNPMKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x33E13A0", Offset = "0x33DFFA0", VA = "0x1833E13A0", Slot = "6")]
	public void JGCOEHFAOLL(T EMKOBNDJJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x33E1010", Offset = "0x33DFC10", VA = "0x1833E1010")]
	public void AIGACLLIPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface MMBNKIOPPNB
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class APEBICLOKNP : global::JBJECBPLCEI<Action>, MMBNKIOPPNB
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5DF0", Offset = "0x4DA49F0", VA = "0x184DA5DF0")]
	public APEBICLOKNP(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5B50", Offset = "0x4DA4750", VA = "0x184DA5B50")]
	public void CKJFIBFNPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5D10", Offset = "0x4DA4910", VA = "0x184DA5D10", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5AF0", Offset = "0x4DA46F0", VA = "0x184DA5AF0")]
	public static APEBICLOKNP BEGGLOIEPOO(APEBICLOKNP AHBJGPGALPF, Action EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5D90", Offset = "0x4DA4990", VA = "0x184DA5D90")]
	public static APEBICLOKNP NMEMLLOCDBD(APEBICLOKNP AHBJGPGALPF, Action EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface AJBNNPPBPNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class DFIKIHHHDJJ<T> : global::JBJECBPLCEI<Action<T>>, global::AJBNNPPBPNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public DFIKIHHHDJJ(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x338E8D0", Offset = "0x338D4D0", VA = "0x18338E8D0")]
	public void CKJFIBFNPJN(T NHMGOELDBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3391CD0", Offset = "0x33908D0", VA = "0x183391CD0", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x338DC40", Offset = "0x338C840", VA = "0x18338DC40")]
	public static global::DFIKIHHHDJJ<T> BEGGLOIEPOO(global::DFIKIHHHDJJ<T> AHBJGPGALPF, Action<T> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3392FA0", Offset = "0x3391BA0", VA = "0x183392FA0")]
	public static global::DFIKIHHHDJJ<T> NMEMLLOCDBD(global::DFIKIHHHDJJ<T> AHBJGPGALPF, Action<T> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface ODDKHJKNJIP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T, U> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T, U> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class OMNGEEHECOA<T, U> : global::JBJECBPLCEI<Action<T, U>>, global::ODDKHJKNJIP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public OMNGEEHECOA(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x340FDB0", Offset = "0x340E9B0", VA = "0x18340FDB0")]
	public void CKJFIBFNPJN(T NHMGOELDBCA, U HALHKAGLDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3413820", Offset = "0x3412420", VA = "0x183413820", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x340EEA0", Offset = "0x340DAA0", VA = "0x18340EEA0")]
	public static global::OMNGEEHECOA<T, U> BEGGLOIEPOO(global::OMNGEEHECOA<T, U> AHBJGPGALPF, Action<T, U> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x34153F0", Offset = "0x3413FF0", VA = "0x1834153F0")]
	public static global::OMNGEEHECOA<T, U> NMEMLLOCDBD(global::OMNGEEHECOA<T, U> AHBJGPGALPF, Action<T, U> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface AGJKLCIIPFB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T, U, V> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T, U, V> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class KBJENFNJCPL<T, U, V> : global::JBJECBPLCEI<Action<T, U, V>>, global::AGJKLCIIPFB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public KBJENFNJCPL(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x35161E0", Offset = "0x3514DE0", VA = "0x1835161E0")]
	public void CKJFIBFNPJN(T NHMGOELDBCA, U HALHKAGLDFB, V EBHCGNBEDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x35197E0", Offset = "0x35183E0", VA = "0x1835197E0", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3516140", Offset = "0x3514D40", VA = "0x183516140")]
	public static global::KBJENFNJCPL<T, U, V> BEGGLOIEPOO(global::KBJENFNJCPL<T, U, V> AHBJGPGALPF, Action<T, U, V> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3519E40", Offset = "0x3518A40", VA = "0x183519E40")]
	public static global::KBJENFNJCPL<T, U, V> NMEMLLOCDBD(global::KBJENFNJCPL<T, U, V> AHBJGPGALPF, Action<T, U, V> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface OCCPOMDMJNC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T, U, V, W> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T, U, V, W> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class EPCGIFCDHDH<T, U, V, W> : global::JBJECBPLCEI<Action<T, U, V, W>>, global::OCCPOMDMJNC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public EPCGIFCDHDH(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3296130", Offset = "0x3294D30", VA = "0x183296130")]
	public void CKJFIBFNPJN(T NHMGOELDBCA, U HALHKAGLDFB, V EBHCGNBEDHN, W FOLOKEFNILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3296B80", Offset = "0x3295780", VA = "0x183296B80", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3294DE0", Offset = "0x32939E0", VA = "0x183294DE0")]
	public static global::EPCGIFCDHDH<T, U, V, W> BEGGLOIEPOO(global::EPCGIFCDHDH<T, U, V, W> AHBJGPGALPF, Action<T, U, V, W> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3297D20", Offset = "0x3296920", VA = "0x183297D20")]
	public static global::EPCGIFCDHDH<T, U, V, W> NMEMLLOCDBD(global::EPCGIFCDHDH<T, U, V, W> AHBJGPGALPF, Action<T, U, V, W> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface DCFMHLOLEEI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T, U, V, W, X> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T, U, V, W, X> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class EHCBJFLOJBC<T, U, V, W, X> : global::JBJECBPLCEI<Action<T, U, V, W, X>>, global::DCFMHLOLEEI<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public EHCBJFLOJBC(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF730", Offset = "0x3EBE330", VA = "0x183EBF730")]
	public void CKJFIBFNPJN(T NHMGOELDBCA, U HALHKAGLDFB, V EBHCGNBEDHN, W FOLOKEFNILH, X JJCLMNFFLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFCF0", Offset = "0x3EBE8F0", VA = "0x183EBFCF0", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF380", Offset = "0x3EBDF80", VA = "0x183EBF380")]
	public static global::EHCBJFLOJBC<T, U, V, W, X> BEGGLOIEPOO(global::EHCBJFLOJBC<T, U, V, W, X> AHBJGPGALPF, Action<T, U, V, W, X> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFFE0", Offset = "0x3EBEBE0", VA = "0x183EBFFE0")]
	public static global::EHCBJFLOJBC<T, U, V, W, X> NMEMLLOCDBD(global::EHCBJFLOJBC<T, U, V, W, X> AHBJGPGALPF, Action<T, U, V, W, X> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface NJBEFLGFKIA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJODILJGAL(Action<T, U, V, W, X, Y> EMKOBNDJJHF, bool ICEMCBNPMKE = false);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCOEHFAOLL(Action<T, U, V, W, X, Y> EMKOBNDJJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class DCHGHLBIKMD<T, U, V, W, X, Y> : global::JBJECBPLCEI<Action<T, U, V, W, X, Y>>, global::NJBEFLGFKIA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35560", VA = "0x182B36960")]
	public DCHGHLBIKMD(bool EKJLDKOMGGB = false, bool BKHPCHGPACI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x338B3C0", Offset = "0x3389FC0", VA = "0x18338B3C0")]
	public void CKJFIBFNPJN(T NHMGOELDBCA, U HALHKAGLDFB, V EBHCGNBEDHN, W FOLOKEFNILH, X JJCLMNFFLAC, Y ACPGHHFEOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x338B9F0", Offset = "0x338A5F0", VA = "0x18338B9F0", Slot = "4")]
	public override void FLCDOMODLMC(object[] JCPCHHDMGJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x338AD50", Offset = "0x3389950", VA = "0x18338AD50")]
	public static global::DCHGHLBIKMD<T, U, V, W, X, Y> BEGGLOIEPOO(global::DCHGHLBIKMD<T, U, V, W, X, Y> AHBJGPGALPF, Action<T, U, V, W, X, Y> EMKOBNDJJHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x338C080", Offset = "0x338AC80", VA = "0x18338C080")]
	public static global::DCHGHLBIKMD<T, U, V, W, X, Y> NMEMLLOCDBD(global::DCHGHLBIKMD<T, U, V, W, X, Y> AHBJGPGALPF, Action<T, U, V, W, X, Y> EMKOBNDJJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class DAICBFKGKCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public readonly struct LEHOPJLPJCA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly global::DAICBFKGKCN<T> GDNEGELFHPB;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public T HNBDKKLMMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x339C7F0", Offset = "0x339B3F0", VA = "0x18339C7F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x339C810", Offset = "0x339B410", VA = "0x18339C810", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x67A640", Offset = "0x679240", VA = "0x18067A640")]
		public LEHOPJLPJCA(global::DAICBFKGKCN<T> GDNEGELFHPB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct APDODHCCOFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<LEHOPJLPJCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::DAICBFKGKCN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3389110", Offset = "0x3387D10", VA = "0x183389110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x33892E0", Offset = "0x3387EE0", VA = "0x1833892E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct OJPLOPPLDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<LEHOPJLPJCA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::DAICBFKGKCN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x339C880", Offset = "0x339B480", VA = "0x18339C880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x33892E0", Offset = "0x3387EE0", VA = "0x1833892E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly SemaphoreSlim CBLOEGKPFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private T ODMJKHKJMHA;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int EDMJEFGODOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x338ABC0", Offset = "0x33897C0", VA = "0x18338ABC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x338ABE0", Offset = "0x33897E0", VA = "0x18338ABE0")]
	public DAICBFKGKCN(in T ODMJKHKJMHA, int AMBFABENFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x338AC80", Offset = "0x3389880", VA = "0x18338AC80")]
	public DAICBFKGKCN(in T ODMJKHKJMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x338A580", Offset = "0x3389180", VA = "0x18338A580")]
	public LEHOPJLPJCA IDHEFDPGGBE()
	{
		return default(LEHOPJLPJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x338A5C0", Offset = "0x33891C0", VA = "0x18338A5C0")]
	public LEHOPJLPJCA IDHEFDPGGBE(CancellationToken OPEHPHNEHDG)
	{
		return default(LEHOPJLPJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x338A600", Offset = "0x3389200", VA = "0x18338A600")]
	[AsyncStateMachine(typeof(global::DAICBFKGKCN<>.APDODHCCOFD))]
	public Task<LEHOPJLPJCA> IGLBNHMPMFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x338A760", Offset = "0x3389360", VA = "0x18338A760")]
	[AsyncStateMachine(typeof(global::DAICBFKGKCN<>.OJPLOPPLDEF))]
	public Task<LEHOPJLPJCA> IGLBNHMPMFH(CancellationToken OPEHPHNEHDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class ELGEBEOBEKG
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA69C0", Offset = "0x4DA55C0", VA = "0x184DA69C0")]
	public static global::DAICBFKGKCN<OFPJGNCHLGN> GPPOAKIDPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6A20", Offset = "0x4DA5620", VA = "0x184DA6A20")]
	public static global::DAICBFKGKCN<OFPJGNCHLGN> GPPOAKIDPIM(int AMBFABENFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBCF0", Offset = "0x1CDA8F0", VA = "0x181CDBCF0")]
	public static global::DAICBFKGKCN<T> GPPOAKIDPIM<T>(in T ODMJKHKJMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1CDC0B0", Offset = "0x1CDACB0", VA = "0x181CDC0B0")]
	public static global::DAICBFKGKCN<T> GPPOAKIDPIM<T>(in T ODMJKHKJMHA, int AMBFABENFNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FCLBAGHPLPP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate bool PHFJGPBBHLJ(global::FCLBAGHPLPP<T> AECOIJJOAMC);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IIINEMLINAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public global::FCLBAGHPLPP<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public IIINEMLINAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2BD73B0", Offset = "0x2BD5FB0", VA = "0x182BD73B0")]
		internal bool <FindNode>b__0(global::FCLBAGHPLPP<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public T KHMIINBLCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public LinkedList<global::FCLBAGHPLPP<T>> CGMPHECPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public global::FCLBAGHPLPP<T> KBHDBHAHGIJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::FCLBAGHPLPP<T> LJMFACFHBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5AF130", Offset = "0x5ADD30", VA = "0x1805AF130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3740", Offset = "0x2BD2340", VA = "0x182BD3740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NCHIPLJJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1D20", Offset = "0x2BD0920", VA = "0x182BD1D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool LNMHMNNOCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3860", Offset = "0x2BD2460", VA = "0x182BD3860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public global::FCLBAGHPLPP<T> DPAECMOKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2BD33D0", Offset = "0x2BD1FD0", VA = "0x182BD33D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3C30", Offset = "0x2BD2830", VA = "0x182BD3C30")]
	public FCLBAGHPLPP(T OCEKDAJHCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3450", Offset = "0x2BD2050", VA = "0x182BD3450")]
	public global::FCLBAGHPLPP<T> KPPCNKKDPML(T IIIGBAMOCIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD38A0", Offset = "0x2BD24A0", VA = "0x182BD38A0")]
	public global::FCLBAGHPLPP<T> PJEOFFOLLPO(T IEPKFCNLHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3320", Offset = "0x2BD1F20", VA = "0x182BD3320")]
	public global::FCLBAGHPLPP<T> JGCOEHFAOLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD18E0", Offset = "0x2BD04E0", VA = "0x182BD18E0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1B40", Offset = "0x2BD0740", VA = "0x182BD1B40")]
	public global::FCLBAGHPLPP<T> BBGMBMPEMDB(T OHKBMFBHBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD27E0", Offset = "0x2BD13E0", VA = "0x182BD27E0")]
	public static void ECGIGCGJKDE(global::FCLBAGHPLPP<T> IBAGNDDHBKL, PHFJGPBBHLJ FJKIFNOIKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x243B4D0", Offset = "0x243A0D0", VA = "0x18243B4D0")]
	public static void ECGIGCGJKDE<A>(global::FCLBAGHPLPP<T> IBAGNDDHBKL, Func<global::FCLBAGHPLPP<T>, A, bool> FJKIFNOIKII, A CEBMIJKEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2BD22A0", Offset = "0x2BD0EA0", VA = "0x182BD22A0")]
	public static string DFNOKLOFPHE(global::FCLBAGHPLPP<T> IBAGNDDHBKL, int ELNAPHFJDMH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3070", Offset = "0x2BD1C70", VA = "0x182BD3070")]
	public static global::FCLBAGHPLPP<T> HMMIFLMKNML(global::FCLBAGHPLPP<T> IBAGNDDHBKL, T FLEIPLINNGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HIEGHEFBCJI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public delegate Task<TResult> ADKPJMDGHNG(TRequest GKGMLGAAHGF, CancellationToken OPEHPHNEHDG);

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum GLNLLBGNJMD
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class IFGPPPALEEK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private const float PMOKOANBAAO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TimeSpan ANANFJBKLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int IEHOCCICICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public GLNLLBGNJMD HHOOOMFLKAG;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly IFGPPPALEEK FJPDIHIOMFH;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float HOMDHGBBADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x3A30860", Offset = "0x3A2F460", VA = "0x183A30860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public TimeSpan JIGEAADAOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3A308D0", Offset = "0x3A2F4D0", VA = "0x183A308D0")]
		public IFGPPPALEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private readonly struct FIALPDBCGJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TRequest GKGMLGAAHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly CancellationToken OPEHPHNEHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly TaskCompletionSource<TResult> JEJJNKPNFPA;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3A23830", Offset = "0x3A22430", VA = "0x183A23830")]
		public FIALPDBCGJM(TRequest GKGMLGAAHGF, TaskCompletionSource<TResult> JEJJNKPNFPA, CancellationToken OPEHPHNEHDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class BPHEKOFNDCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public BPHEKOFNDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x22722A0", Offset = "0x2270EA0", VA = "0x1822722A0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct FLJDEIIMHHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::HIEGHEFBCJI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3A23890", Offset = "0x3A22490", VA = "0x183A23890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6CEFA0", Offset = "0x6CDBA0", VA = "0x1806CEFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BPNDDEAMOCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FIALPDBCGJM req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::HIEGHEFBCJI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public BPNDDEAMOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3A21820", Offset = "0x3A20420", VA = "0x183A21820")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CancellationTokenSource LGLOFENDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<FIALPDBCGJM> FODKBNBCHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly IFGPPPALEEK IGGFLJCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly ADKPJMDGHNG FGHNNHKFPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Task ANKLMHHJONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int GBIKCHKEKMF;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BD20", Offset = "0x3A2A920", VA = "0x183A2BD20")]
	public HIEGHEFBCJI(ADKPJMDGHNG FGHNNHKFPKL, [Optional] IFGPPPALEEK IGGFLJCAJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AE20", Offset = "0x3A29A20", VA = "0x183A2AE20")]
	public Task<TResult> AJCHHAEGFFB(TRequest GKGMLGAAHGF, CancellationToken OPEHPHNEHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B1B0", Offset = "0x3A29DB0", VA = "0x183A2B1B0")]
	private void BKCICGPOLLD(FIALPDBCGJM DBOKEHAHPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A280", Offset = "0x3A28E80", VA = "0x183A2A280")]
	[AsyncStateMachine(typeof(global::HIEGHEFBCJI<, >.FLJDEIIMHHK))]
	private Task ADAPLKLHOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B760", Offset = "0x3A2A360", VA = "0x183A2B760")]
	private FIALPDBCGJM EHLJLNPJLBI()
	{
		return default(FIALPDBCGJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A770", Offset = "0x3A29370", VA = "0x183A2A770")]
	private void AHMMKCGGMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B240", Offset = "0x3A29E40", VA = "0x183A2B240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KGKCFKPNKJG<TKey, TVal> : global::KNBDJMLEMJG<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int ABLDJFPCAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal Dictionary<TKey, (TVal value, int size)> LGHKAMGELLI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	internal override int JMGBAJMMJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x40F1D80", Offset = "0x40F0980", VA = "0x1840F1D80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	internal int BKCGNMJKPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x40F2080", Offset = "0x40F0C80", VA = "0x1840F2080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public override int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x40F1A40", Offset = "0x40F0640", VA = "0x1840F1A40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x40F20B0", Offset = "0x40F0CB0", VA = "0x1840F20B0")]
	public KGKCFKPNKJG(int HNBFBADKDCL, [Optional] EOAPICHCGCM MGHLPBGFNPD, [Optional] IEqualityComparer<TKey> CDPFADOJINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x40F1FE0", Offset = "0x40F0BE0", VA = "0x1840F1FE0")]
	public void JENHFMKFOMB(TKey OMAJLLKKGPH, TVal ODCJDJDBONO, bool KLLBJHLOELP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x40F1EC0", Offset = "0x40F0AC0", VA = "0x1840F1EC0")]
	public bool HONJLELKPPD(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x40F1CD0", Offset = "0x40F08D0", VA = "0x1840F1CD0", Slot = "6")]
	public override bool BOKJIEDKGMF(TKey ELEPIFALAGJ, out TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x40F1AA0", Offset = "0x40F06A0", VA = "0x1840F1AA0")]
	public bool AOEBIFFNJOA(TKey OMAJLLKKGPH, TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x40F1DB0", Offset = "0x40F09B0", VA = "0x1840F1DB0")]
	public bool FMNLMKGPOCD(TKey OMAJLLKKGPH, TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x40F19D0", Offset = "0x40F05D0", VA = "0x1840F19D0", Slot = "7")]
	public override void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x40F1F40", Offset = "0x40F0B40", VA = "0x1840F1F40")]
	private bool IHPMBLOEFGJ(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DefaultMember("Item")]
public class KNBDJMLEMJG<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public delegate int EOAPICHCGCM(TKey OMAJLLKKGPH, TVal ODCJDJDBONO);

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class MGBDEAMNCIE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public TKey LBLIIGONCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public TVal HNBDKKLMMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x6CE8C0", Offset = "0x6CD4C0", VA = "0x1806CE8C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x6CE8E0", Offset = "0x6CD4E0", VA = "0x1806CE8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int CFAAKDNGFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x68BAB0", Offset = "0x68A6B0", VA = "0x18068BAB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x68BAE0", Offset = "0x68A6E0", VA = "0x18068BAE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DateTime LAONOAKEOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x1247A30", Offset = "0x1246630", VA = "0x181247A30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x23D8470", Offset = "0x23D7070", VA = "0x1823D8470")]
		public MGBDEAMNCIE(TKey OMAJLLKKGPH, TVal IFJECFHDAOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int AEEMCLKDFDO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, LinkedListNode<MGBDEAMNCIE>> PDPMIGPBLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly LinkedList<MGBDEAMNCIE> FALHNCKAEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly EOAPICHCGCM MGHLPBGFNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly TimeSpan BNAAPOCOMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly PAAOKLKFBKG GDCHJDDJGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int LIBKBJBEFKG;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int ANAINBHNBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x694EB0", Offset = "0x693AB0", VA = "0x180694EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private bool DOAKBAFKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x23D69A0", Offset = "0x23D55A0", VA = "0x1823D69A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	internal virtual int JMGBAJMMJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x694EC0", Offset = "0x693AC0", VA = "0x180694EC0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private int MAKGNGIINDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1F22730", Offset = "0x1F21330", VA = "0x181F22730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public virtual int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1D7E980", Offset = "0x1D7D580", VA = "0x181D7E980", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<TKey> AMNOMAFPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x23D6780", Offset = "0x23D5380", VA = "0x1823D6780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public TVal ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x23D6750", Offset = "0x23D5350", VA = "0x1823D6750")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x226E850", Offset = "0x226D450", VA = "0x18226E850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x23D6F60", Offset = "0x23D5B60", VA = "0x1823D6F60")]
	public KNBDJMLEMJG(int HNBFBADKDCL, [Optional] EOAPICHCGCM MGHLPBGFNPD, [Optional] IEqualityComparer<TKey> CDPFADOJINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x23D6BF0", Offset = "0x23D57F0", VA = "0x1823D6BF0")]
	public KNBDJMLEMJG(TimeSpan BNAAPOCOMLD, [Optional] IEqualityComparer<TKey> CDPFADOJINB, [Optional] PAAOKLKFBKG GDCHJDDJGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x23D6BA0", Offset = "0x23D57A0", VA = "0x1823D6BA0")]
	public KNBDJMLEMJG(int HNBFBADKDCL, TimeSpan BNAAPOCOMLD, [Optional] IEqualityComparer<TKey> CDPFADOJINB, [Optional] PAAOKLKFBKG GDCHJDDJGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x23D6D10", Offset = "0x23D5910", VA = "0x1823D6D10")]
	public KNBDJMLEMJG(int HNBFBADKDCL, EOAPICHCGCM MGHLPBGFNPD, TimeSpan BNAAPOCOMLD, [Optional] IEqualityComparer<TKey> CDPFADOJINB, [Optional] PAAOKLKFBKG GDCHJDDJGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x23D6A30", Offset = "0x23D5630", VA = "0x1823D6A30")]
	public void PDDNJEDKIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x23D60E0", Offset = "0x23D4CE0", VA = "0x1823D60E0")]
	public void HJBFPPAGLDD(TKey OMAJLLKKGPH, TVal ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x23D65F0", Offset = "0x23D51F0", VA = "0x1823D65F0")]
	public bool JGCOEHFAOLL(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x23D53F0", Offset = "0x23D3FF0", VA = "0x1823D53F0")]
	private TVal AEJJABHJBEM(TKey ELEPIFALAGJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x23D5690", Offset = "0x23D4290", VA = "0x1823D5690", Slot = "6")]
	public virtual bool BOKJIEDKGMF(TKey ELEPIFALAGJ, out TVal ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x23D54A0", Offset = "0x23D40A0", VA = "0x1823D54A0", Slot = "7")]
	public virtual void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x23D5510", Offset = "0x23D4110", VA = "0x1823D5510")]
	private bool ALMNLCECGEI(MGBDEAMNCIE HOFHOBIMEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x23D61A0", Offset = "0x23D4DA0", VA = "0x1823D61A0")]
	private void JDPHPLPDPEG(LinkedListNode<MGBDEAMNCIE> AIPJHAOKKGK, TVal CDPHFIFGDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x23D5B10", Offset = "0x23D4710", VA = "0x1823D5B10")]
	private void CEHHKEGBOJF(TKey OMAJLLKKGPH, TVal ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x23D5E80", Offset = "0x23D4A80", VA = "0x1823D5E80")]
	private void GLHDIPKEGEO(MGBDEAMNCIE HOFHOBIMEKF, TVal CDPHFIFGDLN, int BLNCPMDCDFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public class GNNMKPPFCFG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly List<T> OBBDHGFOJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HashSet<T> NAOJNPFBFNH;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x22722A0", Offset = "0x2270EA0", VA = "0x1822722A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool FGJLGJIJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x34E3C30", Offset = "0x34E2830", VA = "0x1834E3C30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x38B50E0", Offset = "0x38B3CE0", VA = "0x1838B50E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x226A7D0", Offset = "0x22693D0", VA = "0x18226A7D0", Slot = "11")]
	public void Add(T DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x38B4950", Offset = "0x38B3550", VA = "0x1838B4950")]
	public bool GECDJKLEMCP(T DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x38B4EF0", Offset = "0x38B3AF0", VA = "0x1838B4EF0", Slot = "15")]
	public bool Remove(T DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2272090", Offset = "0x2270C90", VA = "0x182272090", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1EF2B50", Offset = "0x1EF1750", VA = "0x181EF2B50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x38B4810", Offset = "0x38B3410", VA = "0x1838B4810", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x23DA0F0", Offset = "0x23D8CF0", VA = "0x1823DA0F0", Slot = "13")]
	public bool Contains(T DDINDLBJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x38B4870", Offset = "0x38B3470", VA = "0x1838B4870", Slot = "14")]
	public void CopyTo(T[] IIIEKHDFIBE, int ALPKDHKFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x25889E0", Offset = "0x25875E0", VA = "0x1825889E0", Slot = "6")]
	public int IndexOf(T DDINDLBJKFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x38B4A20", Offset = "0x38B3620", VA = "0x1838B4A20", Slot = "7")]
	public void Insert(int PMMFOLCEJEJ, T DDINDLBJKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x38B4D50", Offset = "0x38B3950", VA = "0x1838B4D50", Slot = "8")]
	public void RemoveAt(int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x38B4BB0", Offset = "0x38B37B0", VA = "0x1838B4BB0")]
	public void KJIFOFHBNJG(Predicate<T> DBFEOMAHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x38B49F0", Offset = "0x38B35F0", VA = "0x1838B49F0")]
	public void GLFDFAFHDCN(Comparison<T> KPDANNNFPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x38B5000", Offset = "0x38B3C00", VA = "0x1838B5000")]
	public GNNMKPPFCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class BPIGNPNBHOL
{
	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5EB0", Offset = "0x4DA4AB0", VA = "0x184DA5EB0")]
	public static Vector3 DNGECBKLDJN(this GameObject JNOODOEOLDA, float JNFCNJCMPKJ)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1AEFF80", Offset = "0x1AEEB80", VA = "0x181AEFF80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB950", Offset = "0x4DAA550", VA = "0x184DAB950")]
		public SerializedGuid(in Guid IDILPKNCFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB800", Offset = "0x4DAA400", VA = "0x184DAB800")]
		public static SerializedGuid NMIAJDFFGEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB6F0", Offset = "0x4DAA2F0", VA = "0x184DAB6F0")]
		public static SerializedGuid IFGHECBFKOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB4A0", Offset = "0x4DAA0A0", VA = "0x184DAB4A0")]
		public bool BEEAILCAMNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB920", Offset = "0x4DAA520", VA = "0x184DAB920", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB880", Offset = "0x4DAA480", VA = "0x184DAB880", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB770", Offset = "0x4DAA370", VA = "0x184DAB770")]
		public bool KCMIAPKPHME(in Guid IDILPKNCFME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB560", Offset = "0x4DAA160", VA = "0x184DAB560", Slot = "7")]
		public bool Equals(SerializedGuid PJEOMNDGEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB600", Offset = "0x4DAA200", VA = "0x184DAB600", Slot = "0")]
		public override bool Equals(object NJBMHJCLPCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB6E0", Offset = "0x4DAA2E0", VA = "0x184DAB6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB530", Offset = "0x4DAA130", VA = "0x184DAB530", Slot = "6")]
		public int CompareTo(SerializedGuid PJEOMNDGEFC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class FEKJAIFNBON : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly Type CHNCJDNBFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly string OGMCKEJPIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly bool ICCLPPOBJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly bool IJFCIFHLKKB;

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6DE0", Offset = "0x4DA59E0", VA = "0x184DA6DE0")]
	public FEKJAIFNBON(Type IECDKLKDHKN, string GKPGOGKNILC, bool BNAHHHKOGNL = false, bool MOFHMPCIEEN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface ELFMIPLFFNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface PIKMKIHGHHL<T> : ELFMIPLFFNN
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool BCNPNKJHOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string CNNIILHACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PIKMKIHGHHL<T> BHCGHEDCDCK(Action<T> DNIEBCKNEIM);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PIKMKIHGHHL<T> MIDNOBKCPJF(Action<T> DNIEBCKNEIM);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PIKMKIHGHHL<T> BJIMMIOCMHP(Action<T, T> AIBDHKNNGFB);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PIKMKIHGHHL<T> DOIPHLPOJMK(Action<T, T> AIBDHKNNGFB);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::PIKMKIHGHHL<T> BMMJCOJOEOO(Action<string> CECBBCBIELL);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::PIKMKIHGHHL<T> KJEMNJOOGLA(Action<string> CECBBCBIELL);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OIGFCNEDOGP<T> : global::PIKMKIHGHHL<T>, ELFMIPLFFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private global::OMNGEEHECOA<T, T> HCAACNPAIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private global::DFIKIHHHDJJ<T> HHGAEELFKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private global::DFIKIHHHDJJ<string> HKEFJOGJPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private string FPIPAPLJOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private T FNMKBJFEJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool MFMNIDDMEHK;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x22632C0", Offset = "0x2261EC0", VA = "0x1822632C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool BCNPNKJHOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8B0", Offset = "0x5DD4B0", VA = "0x1805DE8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string CNNIILHACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x258D660", Offset = "0x258C260", VA = "0x18258D660", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x340E740", Offset = "0x340D340", VA = "0x18340E740")]
	private void NMGMBMENGDG(T HFMJDCMGFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x340E4E0", Offset = "0x340D0E0", VA = "0x18340E4E0")]
	private void DJEOEEFEHMJ(string PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x340E5D0", Offset = "0x340D1D0", VA = "0x18340E5D0")]
	public void EELNFKPNBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x340E400", Offset = "0x340D000", VA = "0x18340E400", Slot = "6")]
	public global::PIKMKIHGHHL<T> BJIMMIOCMHP(Action<T, T> AIBDHKNNGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x340E580", Offset = "0x340D180", VA = "0x18340E580", Slot = "7")]
	public global::PIKMKIHGHHL<T> DOIPHLPOJMK(Action<T, T> AIBDHKNNGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x340E370", Offset = "0x340CF70", VA = "0x18340E370", Slot = "4")]
	public global::PIKMKIHGHHL<T> BHCGHEDCDCK(Action<T> AIBDHKNNGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x340E6F0", Offset = "0x340D2F0", VA = "0x18340E6F0", Slot = "5")]
	public global::PIKMKIHGHHL<T> MIDNOBKCPJF(Action<T> DNIEBCKNEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x340E450", Offset = "0x340D050", VA = "0x18340E450", Slot = "8")]
	public global::PIKMKIHGHHL<T> BMMJCOJOEOO(Action<string> CECBBCBIELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x340E680", Offset = "0x340D280", VA = "0x18340E680", Slot = "9")]
	public global::PIKMKIHGHHL<T> KJEMNJOOGLA(Action<string> CECBBCBIELL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x340E7E0", Offset = "0x340D3E0", VA = "0x18340E7E0")]
	public OIGFCNEDOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class AOLBGOCLKLM
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class EMDAEPGLHEA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public global::PIKMKIHGHHL<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public global::KHAMONFGMCC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public EMDAEPGLHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBC90", Offset = "0x2ABA890", VA = "0x182ABBC90")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CCAC30", Offset = "0x1CC9830", VA = "0x181CCAC30")]
	public static global::KKLFNGHEAIK<T> EGCDALNBFJM<T>(this global::PIKMKIHGHHL<T> GCMFPLCEJAE, Action<T> DBNMPCEBPKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public abstract class PAAOKLKFBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class AIJFCPFDIIK : PAAOKLKFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static PAAOKLKFBKG PMDDBIJFNMN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x4DA57E0", Offset = "0x4DA43E0", VA = "0x184DA57E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override DateTime MMEBBOLHCMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x4DA5840", Offset = "0x4DA4440", VA = "0x184DA5840", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override float IFMBJGMEEIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x4DA57D0", Offset = "0x4DA43D0", VA = "0x184DA57D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5930", Offset = "0x4DA4530", VA = "0x184DA5930")]
		public AIJFCPFDIIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static PAAOKLKFBKG KLOGIJOGPPP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public static PAAOKLKFBKG FJPDIHIOMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9AB0", Offset = "0x4DA86B0", VA = "0x184DA9AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public abstract DateTime MMEBBOLHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public abstract float IFMBJGMEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	protected PAAOKLKFBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class ACPLOAMNDNA : global::AOGJLFPHDNH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5790", Offset = "0x4DA4390", VA = "0x184DA5790")]
	public ACPLOAMNDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class AOGJLFPHDNH<T> : global::EKAMCFCPMFA<T>, GOIANIOEPCB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Task<T> JEEFDIIDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private Task LJOMPHOPCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDE0", Offset = "0x1CFC9E0", VA = "0x181CFDDE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public global::KKLFNGHEAIK<T> JNOLNHCBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private OBKKHCFLPCB DMHOKJENBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D01DF0", Offset = "0x1D009F0", VA = "0x181D01DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4610", Offset = "0x2AB3210", VA = "0x182AB4610")]
	public AOGJLFPHDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class DPFPABGBJJC : global::PGEPAHNPFFA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6450", Offset = "0x4DA5050", VA = "0x184DA6450")]
	public DPFPABGBJJC(Exception GBDFGDELJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class PGEPAHNPFFA<T> : global::EKAMCFCPMFA<T>, GOIANIOEPCB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Task<T> JEEFDIIDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private Task LJOMPHOPCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDE0", Offset = "0x1CFC9E0", VA = "0x181CFDDE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public global::KKLFNGHEAIK<T> JNOLNHCBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private OBKKHCFLPCB DMHOKJENBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D01DF0", Offset = "0x1D009F0", VA = "0x181D01DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x22751B0", Offset = "0x2273DB0", VA = "0x1822751B0")]
	public PGEPAHNPFFA(Exception GBDFGDELJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface GOIANIOEPCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	[NotNull]
	Task JEEFDIIDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[NotNull]
	OBKKHCFLPCB JNOLNHCBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface EKAMCFCPMFA<T> : GOIANIOEPCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	[NotNull]
	new Task<T> JEEFDIIDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	[NotNull]
	new global::KKLFNGHEAIK<T> JNOLNHCBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class OCKCLABHGJK<TTask, T> : global::EKAMCFCPMFA<T>, GOIANIOEPCB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class HFAKANBMNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public global::OCKCLABHGJK<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public HFAKANBMNKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static bool FHFFEHMMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Task<T> HOPGAGHCNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected readonly CancellationTokenSource EBFGKLICJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool ECJKNINNBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private SynchronizationContext MJKMCGLBOCL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task<T> JEEFDIIDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task LJOMPHOPCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public global::KKLFNGHEAIK<T> JNOLNHCBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private OBKKHCFLPCB DMHOKJENBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1EF21B0", Offset = "0x1EF0DB0", VA = "0x181EF21B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DADHAMOCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DD990", Offset = "0x5DC590", VA = "0x1805DD990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x42E1130", Offset = "0x42DFD30", VA = "0x1842E1130")]
	static OCKCLABHGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x42E1450", Offset = "0x42E0050", VA = "0x1842E1450")]
	protected OCKCLABHGJK(TTask HOPGAGHCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x42E0B50", Offset = "0x42DF750", VA = "0x1842E0B50", Slot = "1")]
	~OCKCLABHGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x361A0C0", Offset = "0x3618CC0", VA = "0x18361A0C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x42E0E00", Offset = "0x42DFA00", VA = "0x1842E0E00")]
	private void GGKDCAFHFBF(bool KNBPDHAPJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FNJNFOGBAJP(TTask BKKLJAEDMFL);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OJDKDOMEBOI();

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x42E0F70", Offset = "0x42DFB70", VA = "0x1842E0F70")]
	[CompilerGenerated]
	private void KGLIPKMKLAJ(object BAOBCCOJLOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class GNPOEDAEAFB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly Type CHNCJDNBFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly string OGMCKEJPIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly bool ICCLPPOBJHB;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8DE0", Offset = "0x4DA79E0", VA = "0x184DA8DE0")]
	public GNPOEDAEAFB(Type IECDKLKDHKN, string GKPGOGKNILC, bool BNAHHHKOGNL = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x55CED0", Offset = "0x55BAD0", VA = "0x18055CED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x580710", Offset = "0x57F310", VA = "0x180580710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public T this[int DAEOPGECNJN, int MFDIBNMAAAD]
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1CFE370", Offset = "0x1CFCF70", VA = "0x181CFE370")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1CFE410", Offset = "0x1CFD010", VA = "0x181CFE410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE2E0", Offset = "0x1CFCEE0", VA = "0x181CFE2E0")]
		public Array2D(uint BJKKDBNGOID, uint HGMHHJIMLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE260", Offset = "0x1CFCE60", VA = "0x181CFE260")]
		public void AIGACLLIPHA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5E50", Offset = "0x4DA4A50", VA = "0x184DA5E50")]
		public Array2DVector3(uint BJKKDBNGOID, uint HGMHHJIMLEJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal static class CLKAIEMABHB
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int GOGBPKPBCIB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public const int NLDOCLJAMKP = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DefaultMember("Item")]
public class CIHNDCBFLJP<THandle, TValue> : IDisposable where THandle : struct, DDFAHKBEHOJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly List<THandle> KPNGGMDDJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly List<TValue> AIFDCAPFPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Func<TValue> NAJGOCDPAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Action<TValue> KDAFFFOBLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int IJAIEBGFDML;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TValue ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x20CC4C0", Offset = "0x20CB0C0", VA = "0x1820CC4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x20CC8B0", Offset = "0x20CB4B0", VA = "0x1820CC8B0")]
	public CIHNDCBFLJP(Action<TValue> KDAFFFOBLOJ, [Optional] Func<TValue> NAJGOCDPAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x20CBF20", Offset = "0x20CAB20", VA = "0x1820CBF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x20CC590", Offset = "0x20CB190", VA = "0x1820CC590")]
	public THandle KGHLJHHMDNN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x20CBEB0", Offset = "0x20CAAB0", VA = "0x1820CBEB0")]
	public THandle DNJODILJGAL(TValue ODCJDJDBONO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x20CC330", Offset = "0x20CAF30", VA = "0x1820CC330")]
	public bool JGCOEHFAOLL(THandle LANDDCNNAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x20CC3E0", Offset = "0x20CAFE0", VA = "0x1820CC3E0")]
	public bool JOHKELGMODK(THandle LANDDCNNAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x20CC020", Offset = "0x20CAC20", VA = "0x1820CC020")]
	public bool EEMBMCCICDG(THandle LANDDCNNAHM, out TValue ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x20CBCE0", Offset = "0x20CA8E0", VA = "0x1820CBCE0")]
	public TValue AEJJABHJBEM(THandle LANDDCNNAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x20CC710", Offset = "0x20CB310", VA = "0x1820CC710")]
	public bool PKLGOFKJGKB(THandle LANDDCNNAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x20CC880", Offset = "0x20CB480", VA = "0x1820CC880")]
	private THandle PLIBMCMFLAM(int PMMFOLCEJEJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x20CC0C0", Offset = "0x20CACC0", VA = "0x1820CC0C0")]
	private TValue EGCDALNBFJM(int PMMFOLCEJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x20CBD30", Offset = "0x20CA930", VA = "0x1820CBD30")]
	private void AHAKOMMNADP(int PMMFOLCEJEJ, in THandle LANDDCNNAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x20CC6D0", Offset = "0x20CB2D0", VA = "0x1820CC6D0")]
	private void NMGMBMENGDG(int PMMFOLCEJEJ, in TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x20CC150", Offset = "0x20CAD50", VA = "0x1820CC150")]
	private THandle HDDKJPMJILG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x20CC7C0", Offset = "0x20CB3C0", VA = "0x1820CC7C0")]
	private void PLHPBDNCANB(THandle LANDDCNNAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x20CBD80", Offset = "0x20CA980", VA = "0x1820CBD80")]
	private int DKBLECIIPAA(int BEDKPKPHEKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x20CBD70", Offset = "0x20CA970", VA = "0x1820CBD70")]
	private bool BKKPBDPEEMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9A0", Offset = "0x5AC5A0", VA = "0x1805AD9A0")]
	private void CDOBDKAOOEC(THandle LANDDCNNAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x20CBFA0", Offset = "0x20CABA0", VA = "0x1820CBFA0")]
	private bool EDHEOCDECIK(out THandle LANDDCNNAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x20CC260", Offset = "0x20CAE60", VA = "0x1820CC260")]
	private bool HOJEDLLJJEE(out THandle LANDDCNNAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x20CC0F0", Offset = "0x20CACF0", VA = "0x1820CC0F0")]
	private void GAIHAMMIPLF(THandle LANDDCNNAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x20CBD90", Offset = "0x20CA990", VA = "0x1820CBD90")]
	private void DNHJPGMJHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public interface DDFAHKBEHOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	int LCGDBDLDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	int EBJEODMLMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface BGJOIFBLCCO<T> : DDFAHKBEHOJ, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class OBGJGACAPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x20F1800", Offset = "0x20F0400", VA = "0x1820F1800")]
	public static bool MNHMDPHFPJO<T>(this T LANDDCNNAHM) where T : struct, DDFAHKBEHOJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class GGJPDHMIHLG
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum AKOJGLBELIK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int AOGNKGPBPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool DDJBPNOALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private AKOJGLBELIK JABEKOPCLNJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PGBMEHBJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4DA8050", Offset = "0x4DA6C50", VA = "0x184DA8050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool NMPKHNMOHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4DA8600", Offset = "0x4DA7200", VA = "0x184DA8600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8DB0", Offset = "0x4DA79B0", VA = "0x184DA8DB0")]
	public GGJPDHMIHLG(bool DDJBPNOALBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8650", Offset = "0x4DA7250", VA = "0x184DA8650")]
	public void GAFJNKMAKOP(object NJBMHJCLPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8C00", Offset = "0x4DA7800", VA = "0x184DA8C00")]
	public void IOPJJMAJJMN(int ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8490", Offset = "0x4DA7090", VA = "0x184DA8490")]
	public void BFGABLNCBLE(uint OONKAPCCGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8BE0", Offset = "0x4DA77E0", VA = "0x184DA8BE0")]
	public void IDNAELCPEHL(bool FHOBPHLLEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4DA85C0", Offset = "0x4DA71C0", VA = "0x184DA85C0")]
	public void DIDLOCNEAPO(long HOJGIKMLMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8610", Offset = "0x4DA7210", VA = "0x184DA8610")]
	public void FEGOHCECIML(ulong BGJPKADOBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8B70", Offset = "0x4DA7770", VA = "0x184DA8B70")]
	public void GLJAMKNHPMB(string GPCMIGFPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8CB0", Offset = "0x4DA78B0", VA = "0x184DA8CB0")]
	public void LFIIOOCJGLP(Enum GBDFGDELJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA84A0", Offset = "0x4DA70A0", VA = "0x184DA84A0")]
	public void CFIKELGKINI(IList OBBDHGFOJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x243D2B0", Offset = "0x243BEB0", VA = "0x18243D2B0")]
	public void LDFJNPGEOOB<T, U>(Dictionary<T, U> ICHMIPGEILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8060", Offset = "0x4DA6C60", VA = "0x184DA8060")]
	private void ALJGIGHNBFF(IDictionary ICHMIPGEILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7FD0", Offset = "0x4DA6BD0", VA = "0x184DA7FD0")]
	public int AHENMKFMKEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8420", Offset = "0x4DA7020", VA = "0x184DA8420")]
	public short BCEELKDFOND()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8040", Offset = "0x4DA6C40", VA = "0x184DA8040")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8D40", Offset = "0x4DA7940", VA = "0x184DA8D40")]
	private void MLINGBEDLDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class LMNBPNELGMB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	internal class LHCGGEHFAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public TNode MPDFMGGHMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public TNode JNKAEALDKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public IELCOEGDLOK FGMFLLPICOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public List<IELCOEGDLOK> LPKGOFBLGFJ;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public LHCGGEHFAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal struct IELCOEGDLOK : IComparable<IELCOEGDLOK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public int KJMNNNBEEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public TClaimant OILNKBFPBPH;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x564CF0", Offset = "0x5638F0", VA = "0x180564CF0")]
		public IELCOEGDLOK(int KJMNNNBEEIK, TClaimant OILNKBFPBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2B23310", Offset = "0x2B21F10", VA = "0x182B23310")]
		public bool IPLDOEBMEAI(in IELCOEGDLOK PJEOMNDGEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2B232F0", Offset = "0x2B21EF0", VA = "0x182B232F0")]
		public bool BCFDOICADOI(in IELCOEGDLOK PJEOMNDGEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2B23300", Offset = "0x2B21F00", VA = "0x182B23300", Slot = "4")]
		public int CompareTo(IELCOEGDLOK PJEOMNDGEFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2B23370", Offset = "0x2B21F70", VA = "0x182B23370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public enum JKGNGJDPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MEHAFPNPDFI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public global::LMNBPNELGMB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2829480", Offset = "0x2828080", VA = "0x182829480")]
		[DebuggerHidden]
		public MEHAFPNPDFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2B305F0", Offset = "0x2B2F1F0", VA = "0x182B305F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2B307B0", Offset = "0x2B2F3B0", VA = "0x182B307B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2B306D0", Offset = "0x2B2F2D0", VA = "0x182B306D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D7F0", Offset = "0x1D0C3F0", VA = "0x181D0D7F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::EAAEJCIFEHG<LHCGGEHFAPH> DHELIOOFIEE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::EAAEJCIFEHG<List<IELCOEGDLOK>> OGCOACJHDOL;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int FDAMGBMJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	internal readonly Dictionary<TClaimant, TNode> HFOHFDKNFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	internal readonly Dictionary<TNode, LHCGGEHFAPH> FHAAMIHHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private JKGNGJDPJJD ODDGPNAKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool IHJIBNHNLFF;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DHLALDPIMMC(TNode AECOIJJOAMC);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LIGNIICLGIE(TNode AECOIJJOAMC, TClaimant BBOHEPOIKJM, TClaimant LIDNNJJFLMH);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D7D0", Offset = "0x2B2C3D0", VA = "0x182B2D7D0")]
	public LMNBPNELGMB(JKGNGJDPJJD ODDGPNAKPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D5F0", Offset = "0x2B2C1F0", VA = "0x182B2D5F0")]
	public void ONOMHHFADAD(TNode AECOIJJOAMC, TNode OHKBMFBHBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D420", Offset = "0x2B2C020", VA = "0x182B2D420")]
	public void OBCIEJMMCOE(TClaimant OILNKBFPBPH, TNode KFPHLOJPMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C940", Offset = "0x2B2B540", VA = "0x182B2C940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D050", Offset = "0x2B2BC50", VA = "0x182B2D050")]
	private void MKHIPFFFOFH(TClaimant OILNKBFPBPH, TNode OEGAHMGHOGM, TNode KFPHLOJPMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CBA0", Offset = "0x2B2B7A0", VA = "0x182B2CBA0")]
	private int EHMCAINNFFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CDA0", Offset = "0x2B2B9A0", VA = "0x182B2CDA0")]
	private void IFIAOOFNGBA(TClaimant OILNKBFPBPH, TNode HMFIFADEDJA, TNode HEEOFFFPCCE, int BELCPFAMLAL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CC10", Offset = "0x2B2B810", VA = "0x182B2CC10")]
	private void HGBOLGIDPFB(IELCOEGDLOK HOMCEAGFOMB, LHCGGEHFAPH DNLLJOAHBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D0F0", Offset = "0x2B2BCF0", VA = "0x182B2D0F0")]
	private void MNEJAHMEOEL(TClaimant OILNKBFPBPH, TNode HMFIFADEDJA, TNode HEEOFFFPCCE, int BELCPFAMLAL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C840", Offset = "0x2B2B440", VA = "0x182B2C840")]
	private void DLKMMBKMCNI(IELCOEGDLOK HOMCEAGFOMB, TNode AECOIJJOAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CCA0", Offset = "0x2B2B8A0", VA = "0x182B2CCA0")]
	private void HJDEPMMGDIL(IELCOEGDLOK HOMCEAGFOMB, LHCGGEHFAPH DNLLJOAHBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2B2BF70", Offset = "0x2B2AB70", VA = "0x182B2BF70")]
	private void AAGOAPCMGBN(LHCGGEHFAPH DNLLJOAHBDH, bool MBAIGPHFABI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C0B0", Offset = "0x2B2ACB0", VA = "0x182B2C0B0")]
	private void BIGFICDIAAK(LHCGGEHFAPH DNLLJOAHBDH, TNode OHKBMFBHBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D520", Offset = "0x2B2C120", VA = "0x182B2D520")]
	[IteratorStateMachine(typeof(global::LMNBPNELGMB<, >.MEHAFPNPDFI))]
	private IEnumerable<TNode> ONMMHKHKAON(TNode HMFIFADEDJA, TNode HEEOFFFPCCE, bool BJCHHKAMMAG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D360", Offset = "0x2B2BF60", VA = "0x182B2D360")]
	private LHCGGEHFAPH NLACAFAPLAI(TNode AECOIJJOAMC, TNode JNKAEALDKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C6B0", Offset = "0x2B2B2B0", VA = "0x182B2C6B0")]
	private LHCGGEHFAPH DFGPKIDBJDE(TNode AECOIJJOAMC, TNode JNKAEALDKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C4F0", Offset = "0x2B2B0F0", VA = "0x182B2C4F0")]
	private void BJOGLNOMILJ(LHCGGEHFAPH DNLLJOAHBDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DGFLMBFKDHP<T> : IEnumerable<global::DGFLMBFKDHP<T>.KNIIPPGJKDJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public struct KNIIPPGJKDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public T ODCJDJDBONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int PMMFOLCEJEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class HDJMLAJJIDM : IEnumerator<KNIIPPGJKDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private global::DGFLMBFKDHP<T> EIACHECNNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int PMMFOLCEJEJ;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x27D4C40", Offset = "0x27D3840", VA = "0x1827D4C40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public KNIIPPGJKDJ PMDANPCIONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x339C3C0", Offset = "0x339AFC0", VA = "0x18339C3C0", Slot = "4")]
			get
			{
				return default(KNIIPPGJKDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8116F0", Offset = "0x8102F0", VA = "0x1808116F0")]
		public HDJMLAJJIDM(global::DGFLMBFKDHP<T> EIACHECNNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x339C330", Offset = "0x339AF30", VA = "0x18339C330", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8116E0", Offset = "0x8102E0", VA = "0x1808116E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7A96D0", Offset = "0x7A82D0", VA = "0x1807A96D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct HLHDBCDLHOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public bool KPLMELMPHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public T ODCJDJDBONO;
	}

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private const int IEBMGCBJKAI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private Dictionary<T, int> FFLBIEGLECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private HLHDBCDLHOC[] IDNGCHJOKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int EDKHPCHKMOL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x22759C0", Offset = "0x22745C0", VA = "0x1822759C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3393620", Offset = "0x3392220", VA = "0x183393620")]
	public static global::DGFLMBFKDHP<T> JOCJMLHIDCD(KNIIPPGJKDJ[] EGPJGKMBALL, bool NAOAFIDOKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3393C50", Offset = "0x3392850", VA = "0x183393C50")]
	public DGFLMBFKDHP(int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2271FF0", Offset = "0x2270BF0", VA = "0x182271FF0")]
	public bool DJJFNOEBDJH(T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3393B70", Offset = "0x3392770", VA = "0x183393B70")]
	public bool OPPPFNOJCLA(int PMMFOLCEJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3393250", Offset = "0x3391E50", VA = "0x183393250")]
	public bool FLMNDNPBPEH(Func<T, bool> HDJKDNNOMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3393040", Offset = "0x3391C40", VA = "0x183393040")]
	public int AFFGAOKAAKF(T ODCJDJDBONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x33931E0", Offset = "0x3391DE0", VA = "0x1833931E0")]
	public T EGCDALNBFJM(int PMMFOLCEJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3393090", Offset = "0x3391C90", VA = "0x183393090")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3393300", Offset = "0x3391F00", VA = "0x183393300")]
	public bool GECDJKLEMCP(T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3393320", Offset = "0x3391F20", VA = "0x183393320")]
	public bool GECDJKLEMCP(T ODCJDJDBONO, int PMMFOLCEJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x33935A0", Offset = "0x33921A0", VA = "0x1833935A0")]
	public bool JGCOEHFAOLL(T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3393190", Offset = "0x3391D90", VA = "0x183393190")]
	public bool DDJBJFOMCJI(int PMMFOLCEJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x33930E0", Offset = "0x3391CE0", VA = "0x1833930E0")]
	private void CCMNJANAICA(int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3393A00", Offset = "0x3392600", VA = "0x183393A00")]
	public KNIIPPGJKDJ[] NLICAOPBBEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3393550", Offset = "0x3392150", VA = "0x183393550")]
	private int HHNHIPCPDGH(int NAIHDOIDODJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3393BD0", Offset = "0x33927D0", VA = "0x183393BD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3393BD0", Offset = "0x33927D0", VA = "0x183393BD0", Slot = "4")]
	private IEnumerator<KNIIPPGJKDJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EAAEJCIFEHG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly Stack<T> INFMAOKKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<T> NHFODBCIHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly int KLKAOPHAECF;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int EHJIAPPBFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1D01570", Offset = "0x1D00170", VA = "0x181D01570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int GEEDABKAMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3293940", Offset = "0x3292540", VA = "0x183293940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7110", Offset = "0x3EB5D10", VA = "0x183EB7110")]
	public static global::EAAEJCIFEHG<T> CHHJDGFKDCG(int HNBFBADKDCL = 0, int KLKAOPHAECF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7630", Offset = "0x3EB6230", VA = "0x183EB7630")]
	public static global::EAAEJCIFEHG<T> FEOJENNKOAM(int HNBFBADKDCL = 0, int KLKAOPHAECF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3EB79A0", Offset = "0x3EB65A0", VA = "0x183EB79A0")]
	public EAAEJCIFEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3EB79E0", Offset = "0x3EB65E0", VA = "0x183EB79E0")]
	public EAAEJCIFEHG(int HNBFBADKDCL, int KLKAOPHAECF = int.MaxValue, bool EEOFDCAGJCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7870", Offset = "0x3EB6470", VA = "0x183EB7870")]
	public T PCCPFMFOADP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7570", Offset = "0x3EB6170", VA = "0x183EB7570")]
	public void FEGEMODNANI(T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3EB77B0", Offset = "0x3EB63B0", VA = "0x183EB77B0")]
	private void ODLGLBBKMOE(T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3EB71E0", Offset = "0x3EB5DE0", VA = "0x183EB71E0")]
	private void CNCFBJBKLNL(T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7200", Offset = "0x3EB5E00", VA = "0x183EB7200")]
	[Conditional("DEBUG_BUILD")]
	private void COBMILJIBCC(T DFNEPGLLAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7700", Offset = "0x3EB6300", VA = "0x183EB7700")]
	[Conditional("DEBUG_BUILD")]
	private void KMFGLNLDKKK(T DFNEPGLLAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7460", Offset = "0x3EB6060", VA = "0x183EB7460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB72A0", Offset = "0x3EB5EA0", VA = "0x183EB72A0")]
	private void COIGDLMJDPE(IEnumerable<T> AIFDCAPFPJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class EBKINFBDONE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Dictionary<int, T> BEHPNMCHMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private T MDHOMCIMMPC;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public virtual T EKKJKIHCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool PFKGEKABDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8E70", Offset = "0x3EB7A70", VA = "0x183EB8E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8880", Offset = "0x3EB7480", VA = "0x183EB8880")]
	public bool CEHHKEGBOJF(T ODCJDJDBONO, int KJMNNNBEEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8940", Offset = "0x3EB7540", VA = "0x183EB8940")]
	public bool CIIPMLIODHF(int KJMNNNBEEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8C10", Offset = "0x3EB7810", VA = "0x183EB8C10")]
	public T POOECKOCHNA(int IKGIMFOLLNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8650", Offset = "0x3EB7250", VA = "0x183EB8650")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3EB87C0", Offset = "0x3EB73C0", VA = "0x183EB87C0")]
	private bool AILDNKHOHNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8850", Offset = "0x3EB7450", VA = "0x183EB8850")]
	public bool BOKJIEDKGMF(int KJMNNNBEEIK, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7270", Offset = "0x2BD5E70", VA = "0x182BD7270")]
	public EBKINFBDONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class NAKDDGMFLGL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	protected struct NOOGCLCGIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public T HNBDKKLMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int GDAHJGCPNPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	protected readonly List<NOOGCLCGIOJ> HLBDBDEKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T DCMAJOKHBJD;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x22722A0", Offset = "0x2270EA0", VA = "0x1822722A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x31D2570", Offset = "0x31D1170", VA = "0x1831D2570")]
	public bool FLMNDNPBPEH(T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x31D23D0", Offset = "0x31D0FD0", VA = "0x1831D23D0")]
	public void DNJODILJGAL(T ODCJDJDBONO, int KJMNNNBEEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x31D27C0", Offset = "0x31D13C0", VA = "0x1831D27C0")]
	public bool JGCOEHFAOLL(T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x31D2160", Offset = "0x31D0D60", VA = "0x1831D2160")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x31D2470", Offset = "0x31D1070", VA = "0x1831D2470")]
	public T EBJOJBKDPLP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x31D2500", Offset = "0x31D1100", VA = "0x1831D2500")]
	public T EHLJLNPJLBI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x31D21C0", Offset = "0x31D0DC0", VA = "0x1831D21C0")]
	private void DDDPMBIGKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x31D28E0", Offset = "0x31D14E0", VA = "0x1831D28E0")]
	public NAKDDGMFLGL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[HPEOBJOJFDN(JHOIPPOHMOA.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x4DA9EB0", Offset = "0x4DA8AB0", VA = "0x184DA9EB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x4DAA380", Offset = "0x4DA8F80", VA = "0x184DAA380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x4DAA1A0", Offset = "0x4DA8DA0", VA = "0x184DAA1A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x4DAA520", Offset = "0x4DA9120", VA = "0x184DAA520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x4DA9D70", Offset = "0x4DA8970", VA = "0x184DA9D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4DAA240", Offset = "0x4DA8E40", VA = "0x184DAA240")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4DAA060", Offset = "0x4DA8C60", VA = "0x184DAA060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9CD0", Offset = "0x4DA88D0", VA = "0x184DA9CD0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public interface KIJLPKCKGHJ
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public abstract class ResourcePrefabReference<T> : KIJLPKCKGHJ where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1D10870", Offset = "0x1D0F470", VA = "0x181D10870", Slot = "4")]
		public virtual T AGEBDMBNFFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class FLEMLJJKOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly Dictionary<byte, NBIHBHLPNJC> GCNMJEOBBFH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NBIHBHLPNJC MIFBBGBEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector2 PLANGDHKHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x13D04F0", Offset = "0x13CF0F0", VA = "0x1813D04F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD71E0", Offset = "0x2BD5DE0", VA = "0x182BD71E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Vector2 HMHAEOCPANO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x14DE4E0", Offset = "0x14DD0E0", VA = "0x1814DE4E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x14DE570", Offset = "0x14DD170", VA = "0x1814DE570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Vector2 KGNEHODIHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x4DA79D0", Offset = "0x4DA65D0", VA = "0x184DA79D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x4DA72E0", Offset = "0x4DA5EE0", VA = "0x184DA72E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int ODMJHEEGCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5877E0", Offset = "0x5863E0", VA = "0x1805877E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9A0", Offset = "0x5AC5A0", VA = "0x1805AD9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA79F0", Offset = "0x4DA65F0", VA = "0x184DA79F0")]
	public FLEMLJJKOPP(Bounds PALIGCLAOJJ, Vector2[] ENMJCBGOCMA, int ADKKIBINCMJ, byte NAIHDOIDODJ, float BIKPELOOFNO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7450", Offset = "0x4DA6050", VA = "0x184DA7450")]
	public NBIHBHLPNJC JMGFOMFBEMI(byte PMMFOLCEJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA71F0", Offset = "0x4DA5DF0", VA = "0x184DA71F0")]
	public void CACCMBOFBCO(Vector3 EAPNHJBIJEF, float PEDLHDKFEPJ, float DFKNFAEHMFB, ref List<byte> CMAIAEJDEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7430", Offset = "0x4DA6030", VA = "0x184DA7430")]
	public void ILGHOCLHIBD(NBIHBHLPNJC.GEOEFJCEOIH EHMPPKBCDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7300", Offset = "0x4DA5F00", VA = "0x184DA7300")]
	private NBIHBHLPNJC DNNPEILHCLN(byte PMMFOLCEJEJ, NBIHBHLPNJC.OPLOFDLCAOB NOAGIKJLMIO, NBIHBHLPNJC JNKAEALDKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA74B0", Offset = "0x4DA60B0", VA = "0x184DA74B0")]
	private void MJCIBGAFNBO(NBIHBHLPNJC JNKAEALDKKD, Vector2[] ENMJCBGOCMA, int NOHHJHDMIFA, int FAPKIKLMDHI, int FIDNFJLLEFK, int AFNOFMBEPFP, float BIKPELOOFNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class NBIHBHLPNJC
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public enum OPLOFDLCAOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public enum GEOEFJCEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public byte IHKIMLOPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Vector3 PNODLDMKGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Vector3 CFAAKDNGFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Vector3 JHLOEBIHNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Vector3 MEFKHPDMNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public OPLOFDLCAOB OFMBBHGFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NBIHBHLPNJC LJMFACFHBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public List<NBIHBHLPNJC> JJMCKHIIHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool NLPAJOFBICK;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA99E0", Offset = "0x4DA85E0", VA = "0x184DA99E0")]
	public NBIHBHLPNJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9980", Offset = "0x4DA8580", VA = "0x184DA9980")]
	public NBIHBHLPNJC(byte DGHEBFGIDHG, OPLOFDLCAOB NOAGIKJLMIO, NBIHBHLPNJC JNKAEALDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9880", Offset = "0x4DA8480", VA = "0x184DA9880")]
	public void KPPCNKKDPML(NBIHBHLPNJC CAFILEDIACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80")]
	public void ILGHOCLHIBD(int IHOJKBFGPOC, GEOEFJCEOIH EHMPPKBCDOE, int AICFMPGEFKJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4DA95B0", Offset = "0x4DA81B0", VA = "0x184DA95B0")]
	public void CACCMBOFBCO(List<byte> CMAIAEJDEBA, Vector3 EAPNHJBIJEF, float PEDLHDKFEPJ, float DFKNFAEHMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9920", Offset = "0x4DA8520", VA = "0x184DA9920")]
	public bool ODBNIILFJDM(Vector3 CDNIKKONEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9840", Offset = "0x4DA8440", VA = "0x184DA9840")]
	public bool JKLENJKMMCM(Vector3 CDNIKKONEFF, float AIEMBJLONJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class FFAKNNAJEOI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Dictionary<T, object> KLMFJOKOPFP;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x23D8600", Offset = "0x23D7200", VA = "0x1823D8600")]
	public bool PCAJMCOONJL(T OAJLENDKBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3D26230", Offset = "0x3D24E30", VA = "0x183D26230")]
	public bool PCAJMCOONJL(T OAJLENDKBOJ, object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D261D0", Offset = "0x3D24DD0", VA = "0x183D261D0")]
	public bool PCAJMCOONJL(T OAJLENDKBOJ, object FOKGBGEFHHH, out object DBPCOOJBIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3D26020", Offset = "0x3D24C20", VA = "0x183D26020")]
	public bool GKPBMGMLIEP(T OAJLENDKBOJ, object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D26190", Offset = "0x3D24D90", VA = "0x183D26190")]
	public bool NAGNEAKOBOB(T OAJLENDKBOJ, object FOKGBGEFHHH, out object DBPCOOJBIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D26060", Offset = "0x3D24C60", VA = "0x183D26060")]
	public bool GKPBMGMLIEP(T OAJLENDKBOJ, object FOKGBGEFHHH, out object DBPCOOJBIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x38E00C0", Offset = "0x38DECC0", VA = "0x1838E00C0")]
	public void AFBAHDABHPI(T OAJLENDKBOJ, object FOKGBGEFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D260F0", Offset = "0x3D24CF0", VA = "0x183D260F0")]
	public void LODLIMHBOJC(T OAJLENDKBOJ, object FOKGBGEFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D26270", Offset = "0x3D24E70", VA = "0x183D26270")]
	public FFAKNNAJEOI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		public struct MEOJLMBKHLP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private readonly List<Component> OBBDHGFOJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private readonly bool NHAOBHNEGCE;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735FB0", VA = "0x1807373B0")]
			public MEOJLMBKHLP(List<Component> OBBDHGFOJGA, bool NHAOBHNEGCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1D06B30", Offset = "0x1D05730", VA = "0x181D06B30")]
			public OEPPLDMFJIN<T> LALDOHEBOCO()
			{
				return default(OEPPLDMFJIN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D06BA0", Offset = "0x1D057A0", VA = "0x181D06BA0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x1D06BA0", Offset = "0x1D057A0", VA = "0x181D06BA0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public struct OEPPLDMFJIN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private readonly List<Component> OBBDHGFOJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			private readonly bool NHAOBHNEGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			private int PMMFOLCEJEJ;

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public T PMDANPCIONM
			{
				[Cpp2IlInjected.Token(Token = "0x60003CE")]
				[Cpp2IlInjected.Address(RVA = "0x1D0AEB0", Offset = "0x1D09AB0", VA = "0x181D0AEB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0x1D0AE40", Offset = "0x1D09A40", VA = "0x181D0AE40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x1D0AE80", Offset = "0x1D09A80", VA = "0x181D0AE80")]
			public OEPPLDMFJIN(List<Component> OBBDHGFOJGA, bool NHAOBHNEGCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x1D0AD70", Offset = "0x1D09970", VA = "0x181D0AD70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x1D0AD80", Offset = "0x1D09980", VA = "0x181D0AD80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x1D0AE30", Offset = "0x1D09A30", VA = "0x181D0AE30", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x4DAC1E0", Offset = "0x4DAADE0", VA = "0x184DAC1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4DAC1A0", Offset = "0x4DAADA0", VA = "0x184DAC1A0")]
		public ToolHierarchyCache(GameObject NANGEAKDCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x4DAC020", Offset = "0x4DAAC20", VA = "0x184DAC020")]
		private void JIBFOCILIBI(GameObject NANGEAKDCPL, bool IONCMNCHLOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DABF90", Offset = "0x4DAAB90", VA = "0x184DABF90")]
		public static void JIBFOCILIBI(GameObject NANGEAKDCPL, ref ToolHierarchyCache EGCLPNLNKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DABE00", Offset = "0x4DAAA00", VA = "0x184DABE00")]
		public void HJFHLMOIGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB980", Offset = "0x4DAA580", VA = "0x184DAB980")]
		public void DHDGFKAFOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C670", Offset = "0x1E7B270", VA = "0x181E7C670")]
		public void CCCGCPGKHPP<T>(Action<T> EMKOBNDJJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x4DABED0", Offset = "0x4DAAAD0", VA = "0x184DABED0")]
		public Component HKBAONIPLMM(Type CEEEOOFNMPD, bool NHAOBHNEGCE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F3DC30", Offset = "0x1F3C830", VA = "0x181F3DC30")]
		public T HKBAONIPLMM<T>(bool NHAOBHNEGCE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x4DABA50", Offset = "0x4DAA650", VA = "0x184DABA50")]
		public MEOJLMBKHLP<Component> FAEEPHLMDKM(Type CEEEOOFNMPD, bool NHAOBHNEGCE = false)
		{
			return default(MEOJLMBKHLP<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x27A76E0", Offset = "0x27A62E0", VA = "0x1827A76E0")]
		public MEOJLMBKHLP<T> FAEEPHLMDKM<T>(bool NHAOBHNEGCE = false) where T : class
		{
			return default(MEOJLMBKHLP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x4DABAE0", Offset = "0x4DAA6E0", VA = "0x184DABAE0")]
		public List<Component> GHEBBOKPEGI(Type CEEEOOFNMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x4DAB9D0", Offset = "0x4DAA5D0", VA = "0x184DAB9D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache JJCLMNFFLAC, ToolHierarchyCache ACPGHHFEOII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x4DABD90", Offset = "0x4DAA990", VA = "0x184DABD90", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NJBMHJCLPCJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class EPKCGHFJOMK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private int HNBFBADKDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private int DMCBBFDHIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private List<T> HMJHMBKGAKH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D01570", Offset = "0x1D00170", VA = "0x181D01570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public T CDOJOBPJHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x32989D0", Offset = "0x32975D0", VA = "0x1832989D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public T ABKMHJFPGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3298990", Offset = "0x3297590", VA = "0x183298990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public T HCIMINIIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3298DA0", Offset = "0x32979A0", VA = "0x183298DA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3298E60", Offset = "0x3297A60", VA = "0x183298E60")]
	public EPKCGHFJOMK(int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3298AF0", Offset = "0x32976F0", VA = "0x183298AF0")]
	public void DNJODILJGAL(T MMAEHPLNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x32988E0", Offset = "0x32974E0", VA = "0x1832988E0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3298D00", Offset = "0x3297900", VA = "0x183298D00")]
	public void ODLFHBKANKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3298CA0", Offset = "0x32978A0", VA = "0x183298CA0")]
	public void MAMLOIJIAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3298CF0", Offset = "0x32978F0", VA = "0x183298CF0")]
	public void MMAAHGGGPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class PLOFPEKLJKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private bool PLAGABNFJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Action EMKOBNDJJHF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public static PLOFPEKLJKH MICGLNIJEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9C50", Offset = "0x4DA8850", VA = "0x184DA9C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool GJGMEKODLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5877B0", Offset = "0x5863B0", VA = "0x1805877B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0A0", Offset = "0x7F9CA0", VA = "0x1807FB0A0")]
	public PLOFPEKLJKH(Action EMKOBNDJJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9C30", Offset = "0x4DA8830", VA = "0x184DA9C30")]
	public void DPCLEGEILBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9C30", Offset = "0x4DA8830", VA = "0x184DA9C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class PJFAJNHMNCB
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80")]
	public static void OINFLIBEGLE(ECLBBDBEJHO JHMCKOBFKPI, string HJILOCNKPJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class FENFILFOPKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct JEFNEAKONDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int GDAHJGCPNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public T HNBDKKLMMPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private Dictionary<object, JEFNEAKONDO> BEHPNMCHMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private T MDHOMCIMMPC;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public virtual T EKKJKIHCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x13D04F0", Offset = "0x13CF0F0", VA = "0x1813D04F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD71E0", Offset = "0x2BD5DE0", VA = "0x182BD71E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool PFKGEKABDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7240", Offset = "0x2BD5E40", VA = "0x182BD7240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public object NICPCIHKIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3D25E10", Offset = "0x3D24A10", VA = "0x183D25E10")]
	public bool CEHHKEGBOJF(T ODCJDJDBONO, object FOKGBGEFHHH, int KJMNNNBEEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7130", Offset = "0x2BD5D30", VA = "0x182BD7130")]
	public bool CIIPMLIODHF(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6AA0", Offset = "0x2BD56A0", VA = "0x182BD6AA0")]
	public bool BOKJIEDKGMF(object FOKGBGEFHHH, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x22763E0", Offset = "0x2274FE0", VA = "0x1822763E0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD62C0", Offset = "0x2BD4EC0", VA = "0x182BD62C0")]
	private bool AILDNKHOHNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7270", Offset = "0x2BD5E70", VA = "0x182BD7270")]
	public FENFILFOPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class CALCGJAOADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private Dictionary<object, float> BEHPNMCHMKK;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public float MIPDDLOAHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE4FC60", Offset = "0xE4E860", VA = "0x180E4FC60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xCCA680", Offset = "0xCC9280", VA = "0x180CCA680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6140", Offset = "0x4DA4D40", VA = "0x184DA6140")]
	public void CEHHKEGBOJF(float ODCJDJDBONO, object FOKGBGEFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA61B0", Offset = "0x4DA4DB0", VA = "0x184DA61B0")]
	public void CIIPMLIODHF(object FOKGBGEFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6220", Offset = "0x4DA4E20", VA = "0x184DA6220")]
	private void GGGPCNDPMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6340", Offset = "0x4DA4F40", VA = "0x184DA6340")]
	public CALCGJAOADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class ECLBBDBEJHO
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class EBEMKMIECFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly string NGFDDHFPPPK;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private EBEMKMIECFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x66E830", Offset = "0x66D430", VA = "0x18066E830")]
		public EBEMKMIECFE(string NGFDDHFPPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x4DA64A0", Offset = "0x4DA50A0", VA = "0x184DA64A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class NCMNNCHGADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public NCMNNCHGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9A00", Offset = "0x4DA8600", VA = "0x184DA9A00")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly HashSet<object> AHMBFNDFCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private int NNEJPNGEPLG;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool DKAKJEGLOFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x4DA6650", Offset = "0x4DA5250", VA = "0x184DA6650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8670", Offset = "0x5E7270", VA = "0x1805E8670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA64F0", Offset = "0x4DA50F0", VA = "0x184DA64F0")]
	public bool DNJODILJGAL(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DA65D0", Offset = "0x4DA51D0", VA = "0x184DA65D0")]
	public bool JGCOEHFAOLL(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6570", Offset = "0x4DA5170", VA = "0x184DA6570")]
	public bool FLMNDNPBPEH(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6660", Offset = "0x4DA5260", VA = "0x184DA6660")]
	public void PFJFFMPBAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA66C0", Offset = "0x4DA52C0", VA = "0x184DA66C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6830", Offset = "0x4DA5430", VA = "0x184DA6830")]
	public ECLBBDBEJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class LBIJMIMFFBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct PEIMBCGIFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public float KFLKAGHBBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T HNBDKKLMMPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Dictionary<object, PEIMBCGIFOI> BEHPNMCHMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private T BGIMELOJAEE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public virtual T GAHIPJKGFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x13A8F10", Offset = "0x13A7B10", VA = "0x1813A8F10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x13A8690", Offset = "0x13A7290", VA = "0x1813A8690", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public object DAEIJPOHFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PFKGEKABDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2ED0570", Offset = "0x2ECF170", VA = "0x182ED0570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0170", Offset = "0x2ECED70", VA = "0x182ED0170")]
	public bool CEHHKEGBOJF(T ODCJDJDBONO, object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0510", Offset = "0x2ECF110", VA = "0x182ED0510")]
	public bool CIIPMLIODHF(object FOKGBGEFHHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x22763E0", Offset = "0x2274FE0", VA = "0x1822763E0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2ECFCC0", Offset = "0x2ECE8C0", VA = "0x182ECFCC0")]
	public bool BOKJIEDKGMF(object FOKGBGEFHHH, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE7E0", Offset = "0x2ECD3E0", VA = "0x182ECE7E0")]
	private bool AILDNKHOHNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2ED05B0", Offset = "0x2ECF1B0", VA = "0x182ED05B0")]
	public LBIJMIMFFBB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8E40", Offset = "0x4DA7A40", VA = "0x184DA8E40")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8F40", Offset = "0x4DA7B40", VA = "0x184DA8F40")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
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
