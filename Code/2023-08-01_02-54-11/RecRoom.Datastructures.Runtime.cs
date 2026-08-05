using System;
using System.Buffers;
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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA4D660", Offset = "0xA4C660", VA = "0x180A4D660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x94AB70", Offset = "0x949B70", VA = "0x18094AB70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x94AB60", Offset = "0x949B60", VA = "0x18094AB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	public virtual void CLPGAKDHGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	[GCAKPCCKPHE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3783FF0", Offset = "0x3782FF0", VA = "0x183783FF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3783750", Offset = "0x3782750", VA = "0x183783750", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3784520", Offset = "0x3783520", VA = "0x183784520")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FJMBMNGHCNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public FJMBMNGHCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4095E90", Offset = "0x4094E90", VA = "0x184095E90")]
		internal int FHKNOECKJJH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[GCAKPCCKPHE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1366570", Offset = "0x1365570", VA = "0x181366570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x13665A0", Offset = "0x13655A0", VA = "0x1813665A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x13664C0", Offset = "0x13654C0", VA = "0x1813664C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey CDBHHMNALJL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1366520", Offset = "0x1365520", VA = "0x181366520", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x13663C0", Offset = "0x13653C0", VA = "0x1813663C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1365EE0", Offset = "0x1364EE0", VA = "0x181365EE0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1365700", Offset = "0x1364700", VA = "0x181365700", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1365380", Offset = "0x1364380", VA = "0x181365380", Slot = "14")]
	protected virtual string KEPKDHJCAFL(TKeyVal MAHOLOLHAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1365290", Offset = "0x1364290", VA = "0x181365290", Slot = "4")]
	public bool ContainsKey(TKey CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13662A0", Offset = "0x13652A0", VA = "0x1813662A0", Slot = "5")]
	public bool TryGetValue(TKey CDBHHMNALJL, out TVal CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x13652C0", Offset = "0x13642C0", VA = "0x1813652C0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x13652C0", Offset = "0x13642C0", VA = "0x1813652C0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x13662D0", Offset = "0x13652D0", VA = "0x1813662D0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class INHOOIIFIPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EDLLKEGPPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public EDLLKEGPPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27CA3F0", Offset = "0x27C93F0", VA = "0x1827CA3F0")]
		internal bool HJLMOMFFNPC(AKDCKAFOKIK<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float OKAPIDADBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float CCAOJMHKIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<AKDCKAFOKIK<float, T>> CGNFFHAJAFE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ACPEIGEIKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x245EEE0", Offset = "0x245DEE0", VA = "0x18245EEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x245F2A0", Offset = "0x245E2A0", VA = "0x18245F2A0")]
	public INHOOIIFIPP(float GJFENMIAAAO, float KHAALNIIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x245EFE0", Offset = "0x245DFE0", VA = "0x18245EFE0")]
	public bool NNCJIJJBJGJ(float CPDGKFHMGPK, T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x245EE80", Offset = "0x245DE80", VA = "0x18245EE80")]
	public int LEEMDCFGNAD(float CPDGKFHMGPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x245EA50", Offset = "0x245DA50", VA = "0x18245EA50")]
	public IEnumerable<T> DHLDPPJLCIA(float CPDGKFHMGPK, [Optional] float? EDGBFDBDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x245ED90", Offset = "0x245DD90", VA = "0x18245ED90")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x245EDC0", Offset = "0x245DDC0", VA = "0x18245EDC0")]
	private void LDLECDDHOON(float CPDGKFHMGPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1180", Offset = "0x2FC0180", VA = "0x182FC1180")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FC11B0", Offset = "0x2FC01B0", VA = "0x182FC11B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float FGINKHBIMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA78F30", Offset = "0xA77F30", VA = "0x180A78F30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E80CF0", Offset = "0x3E7FCF0", VA = "0x183E80CF0")]
	public T AFAONLKFPPJ(float DIIOIJOPPCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E80DE0", Offset = "0x3E7FDE0", VA = "0x183E80DE0")]
	public T OHJLHBJLDEB(float DIIOIJOPPCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PCAAGJODAPP(T BEHCKOODGGG, T IOJJDIDNFKB, float DIIOIJOPPCN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x340BF10", Offset = "0x340AF10", VA = "0x18340BF10", Slot = "4")]
	protected override float PCAAGJODAPP(float BEHCKOODGGG, float IOJJDIDNFKB, float DIIOIJOPPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x713A850", Offset = "0x7139850", VA = "0x18713A850")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x16FB7D0", Offset = "0x16FA7D0", VA = "0x1816FB7D0", Slot = "4")]
	protected override Vector3 PCAAGJODAPP(Vector3 BEHCKOODGGG, Vector3 IOJJDIDNFKB, float DIIOIJOPPCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7140B80", Offset = "0x713FB80", VA = "0x187140B80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x713A650", Offset = "0x7139650", VA = "0x18713A650", Slot = "4")]
	protected override Color PCAAGJODAPP(Color BEHCKOODGGG, Color IOJJDIDNFKB, float DIIOIJOPPCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x713A6B0", Offset = "0x71396B0", VA = "0x18713A6B0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HFHJKBLAHHE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IDHHMDPEIME<T1, T2> : IEnumerable<AKDCKAFOKIK<T1, T2>>, IEnumerable, IEnumerator<AKDCKAFOKIK<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private AKDCKAFOKIK<T1, T2> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerable<T1> a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IEnumerable<T1> <>3__a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IEnumerable<T2> b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IEnumerable<T2> <>3__b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IEnumerator<T1> <itrA>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<T2> <itrB>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool <itrAContinue>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool <itrBContinue>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private T1 <elementA>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T2 <elementB>5__6;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		AKDCKAFOKIK<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public IDHHMDPEIME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x185A020", Offset = "0x1859020", VA = "0x18185A020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x185A390", Offset = "0x1859390", VA = "0x18185A390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x185A2D0", Offset = "0x18592D0", VA = "0x18185A2D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<AKDCKAFOKIK<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x13561E0", Offset = "0x13551E0", VA = "0x1813561E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class COPNIONPMBG<T1, T2, T3> : IEnumerable<HPLILDOLGHF<T1, T2, T3>>, IEnumerable, IEnumerator<HPLILDOLGHF<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HPLILDOLGHF<T1, T2, T3> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IEnumerable<T1> a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEnumerable<T1> <>3__a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerable<T2> b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IEnumerable<T2> <>3__b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IEnumerable<T3> c;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public IEnumerable<T3> <>3__c;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IEnumerator<T1> <itrA>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<T2> <itrB>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerator<T3> <itrC>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool <itrAContinue>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <itrBContinue>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool <itrCContinue>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private T1 <elementA>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private T2 <elementB>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private T3 <elementC>5__9;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		HPLILDOLGHF<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public COPNIONPMBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E120", Offset = "0x1F3D120", VA = "0x181F3E120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E600", Offset = "0x1F3D600", VA = "0x181F3E600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E530", Offset = "0x1F3D530", VA = "0x181F3E530", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<HPLILDOLGHF<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1F36CD0", Offset = "0x1F35CD0", VA = "0x181F36CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x13ED190", Offset = "0x13EC190", VA = "0x1813ED190")]
	public static ICADNDBDDPP<T1> GGPPECCFBMF<T1>(T1 EEOMIMHKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2969CD0", Offset = "0x2968CD0", VA = "0x182969CD0")]
	public static AKDCKAFOKIK<T1, T2> GGPPECCFBMF<T1, T2>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2969D40", Offset = "0x2968D40", VA = "0x182969D40")]
	public static HPLILDOLGHF<T1, T2, T3> GGPPECCFBMF<T1, T2, T3>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x13E92A0", Offset = "0x13E82A0", VA = "0x1813E92A0")]
	public static ACMADHNFNOP<T1, T2, T3, T4> GGPPECCFBMF<T1, T2, T3, T4>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x296A010", Offset = "0x2969010", VA = "0x18296A010")]
	public static MEJDPHAGLJJ<T1, T2, T3, T4, T5> GGPPECCFBMF<T1, T2, T3, T4, T5>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2969F60", Offset = "0x2968F60", VA = "0x182969F60")]
	public static LKEKKEJABIJ<T1, T2, T3, T4, T5, T6> GGPPECCFBMF<T1, T2, T3, T4, T5, T6>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2969EA0", Offset = "0x2968EA0", VA = "0x182969EA0")]
	public static MFOKHDPOIFO<T1, T2, T3, T4, T5, T6, T7> GGPPECCFBMF<T1, T2, T3, T4, T5, T6, T7>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP, T7 CDEOJEHALKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2969DD0", Offset = "0x2968DD0", VA = "0x182969DD0")]
	public static LKADDOMOBIH<T1, T2, T3, T4, T5, T6, T7, T8> GGPPECCFBMF<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP, T7 CDEOJEHALKP, T8 FMKBELKHFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xFF9680", Offset = "0xFF8680", VA = "0x180FF9680")]
	[IteratorStateMachine(typeof(IDHHMDPEIME<, >))]
	public static IEnumerable<AKDCKAFOKIK<T1, T2>> PAPFKAHJBEI<T1, T2>(IEnumerable<T1> CDICEDNOPPN, IEnumerable<T2> ANCILJKDKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xFF9720", Offset = "0xFF8720", VA = "0x180FF9720")]
	[IteratorStateMachine(typeof(COPNIONPMBG<, , >))]
	public static IEnumerable<HPLILDOLGHF<T1, T2, T3>> PAPFKAHJBEI<T1, T2, T3>(IEnumerable<T1> CDICEDNOPPN, IEnumerable<T2> ANCILJKDKHM, IEnumerable<T3> EHMKNANNEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x713B4A0", Offset = "0x713A4A0", VA = "0x18713B4A0")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x713B3F0", Offset = "0x713A3F0", VA = "0x18713B3F0")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x713B430", Offset = "0x713A430", VA = "0x18713B430")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM, int PGEJNIAOCLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x713B480", Offset = "0x713A480", VA = "0x18713B480")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM, int PGEJNIAOCLI, int JGPFPEHEMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x713B400", Offset = "0x713A400", VA = "0x18713B400")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM, int PGEJNIAOCLI, int JGPFPEHEMCO, int BPLGOICLHHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x713B3C0", Offset = "0x713A3C0", VA = "0x18713B3C0")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM, int PGEJNIAOCLI, int JGPFPEHEMCO, int BPLGOICLHHJ, int CPOBCMBNFGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x713B450", Offset = "0x713A450", VA = "0x18713B450")]
	internal static int FPMNNLPDIME(int CPNBBKHNBHH, int KIMBOHIEOCO, int EDLLFEDCIKM, int PGEJNIAOCLI, int JGPFPEHEMCO, int BPLGOICLHHJ, int CPOBCMBNFGN, int EEMNHKMHKNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ICADNDBDDPP<T1> : IComparable<ICADNDBDDPP<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xEDE1E0", Offset = "0xEDD1E0", VA = "0x180EDE1E0")]
	public ICADNDBDDPP(T1 EEOMIMHKNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1851EA0", Offset = "0x1850EA0", VA = "0x181851EA0", Slot = "4")]
	public int CompareTo(ICADNDBDDPP<T1> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1851F10", Offset = "0x1850F10", VA = "0x181851F10", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1851FB0", Offset = "0x1850FB0", VA = "0x181851FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1851FE0", Offset = "0x1850FE0", VA = "0x181851FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AKDCKAFOKIK<T1, T2> : IComparable<AKDCKAFOKIK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F02250", Offset = "0x1F01250", VA = "0x181F02250")]
	public AKDCKAFOKIK(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x35063C0", Offset = "0x35053C0", VA = "0x1835063C0", Slot = "4")]
	public int CompareTo(AKDCKAFOKIK<T1, T2> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3506850", Offset = "0x3505850", VA = "0x183506850", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3507400", Offset = "0x3506400", VA = "0x183507400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3507830", Offset = "0x3506830", VA = "0x183507830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HPLILDOLGHF<T1, T2, T3> : IComparable<HPLILDOLGHF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3522800", Offset = "0x3521800", VA = "0x183522800")]
	public HPLILDOLGHF(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3521FC0", Offset = "0x3520FC0", VA = "0x183521FC0", Slot = "4")]
	public int CompareTo(HPLILDOLGHF<T1, T2, T3> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x35221C0", Offset = "0x35211C0", VA = "0x1835221C0", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3522450", Offset = "0x3521450", VA = "0x183522450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3522540", Offset = "0x3521540", VA = "0x183522540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ACMADHNFNOP<T1, T2, T3, T4> : IComparable<ACMADHNFNOP<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 AAPHACJBCML;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F058F0", Offset = "0x1F048F0", VA = "0x181F058F0")]
	public ACMADHNFNOP(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D53B40", Offset = "0x3D52B40", VA = "0x183D53B40", Slot = "4")]
	public int CompareTo(ACMADHNFNOP<T1, T2, T3, T4> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C80", Offset = "0x3D52C80", VA = "0x183D53C80", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3D53DC0", Offset = "0x3D52DC0", VA = "0x183D53DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3D53E80", Offset = "0x3D52E80", VA = "0x183D53E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MEJDPHAGLJJ<T1, T2, T3, T4, T5> : IComparable<MEJDPHAGLJJ<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 AAPHACJBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 KHHBBMNAEDN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x241A8A0", Offset = "0x24198A0", VA = "0x18241A8A0")]
	public MEJDPHAGLJJ(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29DD6E0", Offset = "0x29DC6E0", VA = "0x1829DD6E0", Slot = "4")]
	public int CompareTo(MEJDPHAGLJJ<T1, T2, T3, T4, T5> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29DD860", Offset = "0x29DC860", VA = "0x1829DD860", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29DD9D0", Offset = "0x29DC9D0", VA = "0x1829DD9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29DDAD0", Offset = "0x29DCAD0", VA = "0x1829DDAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LKEKKEJABIJ<T1, T2, T3, T4, T5, T6> : IComparable<LKEKKEJABIJ<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 AAPHACJBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 KHHBBMNAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 GHLAFGMILEO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E77390", Offset = "0x2E76390", VA = "0x182E77390")]
	public LKEKKEJABIJ(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E76DB0", Offset = "0x2E75DB0", VA = "0x182E76DB0", Slot = "4")]
	public int CompareTo(LKEKKEJABIJ<T1, T2, T3, T4, T5, T6> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E76F70", Offset = "0x2E75F70", VA = "0x182E76F70", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E77100", Offset = "0x2E76100", VA = "0x182E77100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2E77220", Offset = "0x2E76220", VA = "0x182E77220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MFOKHDPOIFO<T1, T2, T3, T4, T5, T6, T7> : IComparable<MFOKHDPOIFO<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 AAPHACJBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 KHHBBMNAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 GHLAFGMILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 OJBFPGLCHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x29E0860", Offset = "0x29DF860", VA = "0x1829E0860")]
	public MFOKHDPOIFO(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP, T7 CDEOJEHALKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29E01C0", Offset = "0x29DF1C0", VA = "0x1829E01C0", Slot = "4")]
	public int CompareTo(MFOKHDPOIFO<T1, T2, T3, T4, T5, T6, T7> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x29E03C0", Offset = "0x29DF3C0", VA = "0x1829E03C0", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x29E0580", Offset = "0x29DF580", VA = "0x1829E0580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29E06D0", Offset = "0x29DF6D0", VA = "0x1829E06D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LKADDOMOBIH<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<LKADDOMOBIH<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 LGBGBMOAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 HJDHMNDANNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 OPBAABHJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 AAPHACJBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 KHHBBMNAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 GHLAFGMILEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 OJBFPGLCHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 OBNKAEHKHBE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2E76CE0", Offset = "0x2E75CE0", VA = "0x182E76CE0")]
	public LKADDOMOBIH(T1 EEOMIMHKNLI, T2 LIGFCHMPGPD, T3 COENDAGDFMP, T4 HKGMLPIBOHM, T5 JKOILJBCHJM, T6 FIFOAIFPFFP, T7 CDEOJEHALKP, T8 FMKBELKHFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2E76590", Offset = "0x2E75590", VA = "0x182E76590", Slot = "4")]
	public int CompareTo(LKADDOMOBIH<T1, T2, T3, T4, T5, T6, T7, T8> JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2E767E0", Offset = "0x2E757E0", VA = "0x182E767E0", Slot = "0")]
	public override bool Equals(object JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2E769C0", Offset = "0x2E759C0", VA = "0x182E769C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2E76B30", Offset = "0x2E75B30", VA = "0x182E76B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GCAKPCCKPHE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	public GCAKPCCKPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, LMAPCMEKCLJ, POAIAHAEMLD, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xACC050", Offset = "0xACB050", VA = "0x180ACC050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HCAPEIIEPID);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[HNHFGMBAPHI]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[HNHFGMBAPHI]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x713F950", Offset = "0x713E950", VA = "0x18713F950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x713F910", Offset = "0x713E910", VA = "0x18713F910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x713F990", Offset = "0x713E990", VA = "0x18713F990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x713FB40", Offset = "0x713EB40", VA = "0x18713FB40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x713FAB0", Offset = "0x713EAB0", VA = "0x18713FAB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9877B0", Offset = "0x9867B0", VA = "0x1809877B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x987830", Offset = "0x986830", VA = "0x180987830")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x713F8D0", Offset = "0x713E8D0", VA = "0x18713F8D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x713FA20", Offset = "0x713EA20", VA = "0x18713FA20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x713F320", Offset = "0x713E320", VA = "0x18713F320")]
	public void CopyBounds(SavedExtents JONIFABKCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x713F830", Offset = "0x713E830", VA = "0x18713F830")]
	public void SetLocalSpaceBounds(Bounds GMHMNOJEJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x713ECC0", Offset = "0x713DCC0", VA = "0x18713ECC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x713F820", Offset = "0x713E820", VA = "0x18713F820")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x713F410", Offset = "0x713E410", VA = "0x18713F410")]
	private void JKEOLFFBKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x713F5F0", Offset = "0x713E5F0", VA = "0x18713F5F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x713ECE0", Offset = "0x713DCE0", VA = "0x18713ECE0")]
	public static void CalculateLocalBoundsFor(GameObject IHNGPGNCBCG, out Bounds GMHMNOJEJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x713F350", Offset = "0x713E350", VA = "0x18713F350")]
	private static void EEAAGOLCPNO(Bounds ANCILJKDKHM, Color EHMKNANNEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x713F850", Offset = "0x713E850", VA = "0x18713F850")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JNPMOEHOPBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct BJJIJGHNAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T MNHGIJMEOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float AMOCGPKFGCD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float NGKGDINJDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> JFAGEIMDALK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int HJOPHJHHDEJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private BJJIJGHNAGH[] OGEGDDKCPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int ABDKHNIPIKD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float DLIMBAHELFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xDADE30", Offset = "0xDACE30", VA = "0x180DADE30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBDC100", Offset = "0xBDB100", VA = "0x180BDC100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x342B170", Offset = "0x342A170", VA = "0x18342B170")]
	public JNPMOEHOPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x342B070", Offset = "0x342A070", VA = "0x18342B070")]
	public JNPMOEHOPBB(int GFFJJOEGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x342AA90", Offset = "0x3429A90", VA = "0x18342AA90")]
	public void KKDPLFKFCJN(float CPDGKFHMGPK, T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x342A610", Offset = "0x3429610", VA = "0x18342A610")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x342A300", Offset = "0x3429300", VA = "0x18342A300")]
	public bool CBDPLBEEGEM(float LCHBLBGEFHN, float NDPBILIPNAJ, out T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x342AD50", Offset = "0x3429D50", VA = "0x18342AD50")]
	public bool PFOIEIMHKLA(float LCHBLBGEFHN, float NDPBILIPNAJ, out T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3429B90", Offset = "0x3428B90", VA = "0x183429B90")]
	public void AFDJPMBJHHM(float LCHBLBGEFHN, float NDPBILIPNAJ, List<T> FFBNIGIPHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x342AB70", Offset = "0x3429B70", VA = "0x18342AB70")]
	private int LFBPDIHJNNH(int HHBJNMGMHLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x342A8B0", Offset = "0x34298B0", VA = "0x18342A8B0")]
	private void HCPLBJKIJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CMNHIJNKGPC();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PCAAGJODAPP(T BEHCKOODGGG, T IOJJDIDNFKB, float DIIOIJOPPCN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T ABGNGMBGNEJ(T CKMKMNKGMMC, float DIIOIJOPPCN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LCGAPHHCJIL(T BEHCKOODGGG, T IOJJDIDNFKB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T OOPCKKHMLNO(T BEHCKOODGGG, T IOJJDIDNFKB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ABAGGKHMEPC : JNPMOEHOPBB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xF00BA0", Offset = "0xEFFBA0", VA = "0x180F00BA0", Slot = "4")]
	protected override Vector3 CMNHIJNKGPC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x16FB7D0", Offset = "0x16FA7D0", VA = "0x1816FB7D0", Slot = "5")]
	protected override Vector3 PCAAGJODAPP(Vector3 BEHCKOODGGG, Vector3 IOJJDIDNFKB, float DIIOIJOPPCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x71392B0", Offset = "0x71382B0", VA = "0x1871392B0", Slot = "6")]
	protected override Vector3 ABGNGMBGNEJ(Vector3 CKMKMNKGMMC, float DIIOIJOPPCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71392F0", Offset = "0x71382F0", VA = "0x1871392F0", Slot = "7")]
	protected override Vector3 LCGAPHHCJIL(Vector3 BEHCKOODGGG, Vector3 IOJJDIDNFKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7139340", Offset = "0x7138340", VA = "0x187139340", Slot = "8")]
	protected override Vector3 OOPCKKHMLNO(Vector3 BEHCKOODGGG, Vector3 IOJJDIDNFKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x71393B0", Offset = "0x71383B0", VA = "0x1871393B0")]
	public ABAGGKHMEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DCECNBMNKEF : JNPMOEHOPBB<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x713A780", Offset = "0x7139780", VA = "0x18713A780")]
	public DCECNBMNKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x713A710", Offset = "0x7139710", VA = "0x18713A710")]
	public DCECNBMNKEF(int GFFJJOEGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xA0C1F0", Offset = "0xA0B1F0", VA = "0x180A0C1F0", Slot = "4")]
	protected override float CMNHIJNKGPC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x340BF10", Offset = "0x340AF10", VA = "0x18340BF10", Slot = "5")]
	protected override float PCAAGJODAPP(float BEHCKOODGGG, float IOJJDIDNFKB, float DIIOIJOPPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x597D4D0", Offset = "0x597C4D0", VA = "0x18597D4D0", Slot = "6")]
	protected override float ABGNGMBGNEJ(float CKMKMNKGMMC, float DIIOIJOPPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x713A6F0", Offset = "0x71396F0", VA = "0x18713A6F0", Slot = "7")]
	protected override float LCGAPHHCJIL(float BEHCKOODGGG, float IOJJDIDNFKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x713A700", Offset = "0x7139700", VA = "0x18713A700", Slot = "8")]
	protected override float OOPCKKHMLNO(float BEHCKOODGGG, float IOJJDIDNFKB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JEBEBNPNMPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable PCFKPPACGDB;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public JEBEBNPNMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AEDAHNFOAEP : JBPLGEJIHGM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7139490", Offset = "0x7138490", VA = "0x187139490")]
	public AEDAHNFOAEP(int JEBBAFBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71394E0", Offset = "0x71384E0", VA = "0x1871394E0")]
	public AEDAHNFOAEP(GMOKJKFLIIJ[] PIGAGHHOGGP, bool MDLNEJBEOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7139420", Offset = "0x7138420", VA = "0x187139420", Slot = "6")]
	protected override uint MPGELMJLJAO(uint HCAPEIIEPID, string CKMKMNKGMMC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DLHFJEGFNBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct ACKDCBNMCJB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly DLHFJEGFNBH<T> OCLAJHFLAJD;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T MNHGIJMEOAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3D53B20", Offset = "0x3D52B20", VA = "0x183D53B20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D53AF0", Offset = "0x3D52AF0", VA = "0x183D53AF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
		public ACKDCBNMCJB(DLHFJEGFNBH<T> OCLAJHFLAJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BBPJBBNHGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<ACKDCBNMCJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DLHFJEGFNBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public BBPJBBNHGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x53D3C40", Offset = "0x53D2C40", VA = "0x1853D3C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PDIPLDGEIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<ACKDCBNMCJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DLHFJEGFNBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public PDIPLDGEIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x32DD540", Offset = "0x32DC540", VA = "0x1832DD540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim JGJGDOAGDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T BKMOONPCPDG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FIJFLJBDAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x37D0B50", Offset = "0x37CFB50", VA = "0x1837D0B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x37D13C0", Offset = "0x37D03C0", VA = "0x1837D13C0")]
	public DLHFJEGFNBH(in T BKMOONPCPDG, int MMKJGOFEIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x37D12F0", Offset = "0x37D02F0", VA = "0x1837D12F0")]
	public DLHFJEGFNBH(in T BKMOONPCPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x37D0B70", Offset = "0x37CFB70", VA = "0x1837D0B70")]
	public ACKDCBNMCJB KPKKEJPICIO()
	{
		return default(ACKDCBNMCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37D0BB0", Offset = "0x37CFBB0", VA = "0x1837D0BB0")]
	public ACKDCBNMCJB KPKKEJPICIO(CancellationToken AOAEIGNDKPI)
	{
		return default(ACKDCBNMCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x37D0DC0", Offset = "0x37CFDC0", VA = "0x1837D0DC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLHFJEGFNBH<>.BBPJBBNHGIG))]
	public Task<ACKDCBNMCJB> LJNODHBNEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x37D0BF0", Offset = "0x37CFBF0", VA = "0x1837D0BF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DLHFJEGFNBH<>.PDIPLDGEIFA))]
	public Task<ACKDCBNMCJB> LJNODHBNEPP(CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CINPOKNHNLC
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x713A5F0", Offset = "0x71395F0", VA = "0x18713A5F0")]
	public static DLHFJEGFNBH<OKHGFHBPFAA> CECGBIGMPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x713A580", Offset = "0x7139580", VA = "0x18713A580")]
	public static DLHFJEGFNBH<OKHGFHBPFAA> CECGBIGMPDN(int MMKJGOFEIGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x13ED190", Offset = "0x13EC190", VA = "0x1813ED190")]
	public static DLHFJEGFNBH<T> CECGBIGMPDN<T>(in T BKMOONPCPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x18947F0", Offset = "0x18937F0", VA = "0x1818947F0")]
	public static DLHFJEGFNBH<T> CECGBIGMPDN<T>(in T BKMOONPCPDG, int MMKJGOFEIGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class NCIDKCGKDJH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NCIDKCGKDJH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA1FB30", Offset = "0xA1EB30", VA = "0x180A1FB30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x26165B0", Offset = "0x26155B0", VA = "0x1826165B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x26187C0", Offset = "0x26177C0", VA = "0x1826187C0")]
		public Enumerator(NCIDKCGKDJH<T> FFBNIGIPHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2613650", Offset = "0x2612650", VA = "0x182613650", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2614760", Offset = "0x2613760", VA = "0x182614760", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2613F30", Offset = "0x2612F30", VA = "0x182613F30")]
		private void OININFCEIDH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] INFBIEOEIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int GOKCMPDIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int ILEBHLNPNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int DFLAEIEBLPA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2876910", Offset = "0x2875910", VA = "0x182876910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2876700", Offset = "0x2875700", VA = "0x182876700")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2876B20", Offset = "0x2875B20", VA = "0x182876B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28785A0", Offset = "0x28775A0", VA = "0x1828785A0")]
	public NCIDKCGKDJH(int JEBBAFBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28771D0", Offset = "0x28761D0", VA = "0x1828771D0")]
	public void KKDPLFKFCJN(T DIIOIJOPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2877410", Offset = "0x2876410", VA = "0x182877410")]
	public void LDKJPGOJLHA(IEnumerable<T> EEBPEGLIDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2876A10", Offset = "0x2875A10", VA = "0x182876A10")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2878390", Offset = "0x2877390", VA = "0x182878390")]
	public void LLIKIEPLPFI(int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2876980", Offset = "0x2875980", VA = "0x182876980")]
	public void EMPDIFLBFJL(int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2876D60", Offset = "0x2875D60", VA = "0x182876D60")]
	public void IEPALCONJIK(T[] OGEGDDKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28768C0", Offset = "0x28758C0", VA = "0x1828768C0")]
	public Enumerator DHFGGODEIOI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2878420", Offset = "0x2877420", VA = "0x182878420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2878420", Offset = "0x2877420", VA = "0x182878420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x28781B0", Offset = "0x28771B0", VA = "0x1828781B0")]
	private int LJJDMICPJLK(int EJNMEMKEIOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2876950", Offset = "0x2875950", VA = "0x182876950")]
	private int EENHNMFAPGM(int EJNMEMKEIOD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class MELGNLKMNLN
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FMHGLEIEAAO(object[] JMLOLLOGKEE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	protected MELGNLKMNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class BLCJCJJLNKL<T> : MELGNLKMNLN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct HJPBIADGBAP
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum MGHIINEBNBF
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MGHIINEBNBF FLAJIGGIBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T NPNCNABHINE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int INPFJEFDLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool JEBCOPPDHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool AGOIIBKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> GLFNMHDMOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<HJPBIADGBAP> CKDAICADOFJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool LBJMBEDONIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x263E9E0", Offset = "0x263D9E0", VA = "0x18263E9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x263ED30", Offset = "0x263DD30", VA = "0x18263ED30")]
	protected BLCJCJJLNKL(bool AGOIIBKJOPP, bool JEBCOPPDHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x263E640", Offset = "0x263D640", VA = "0x18263E640")]
	protected bool CJBEDILGCAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x263E920", Offset = "0x263D920", VA = "0x18263E920")]
	protected void HMLAIPICNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x263EB80", Offset = "0x263DB80", VA = "0x18263EB80")]
	protected void LEDJLACBBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29B7EE0", Offset = "0x29B6EE0", VA = "0x1829B7EE0")]
	private static void HIOJLPCDOOE<U>(ref List<U> IHMGNIOOIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x263EA20", Offset = "0x263DA20", VA = "0x18263EA20", Slot = "5")]
	public void KKDPLFKFCJN(T NPNCNABHINE, bool AHDBJDGNHKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x263E7D0", Offset = "0x263D7D0", VA = "0x18263E7D0", Slot = "6")]
	public void HBPDDHHFGHN(T NPNCNABHINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x263E6C0", Offset = "0x263D6C0", VA = "0x18263E6C0")]
	public void EPCDHGCGJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JHMAFDCFMHF
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class MONMJFCKPLO : BLCJCJJLNKL<Action>, JHMAFDCFMHF
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x713E310", Offset = "0x713D310", VA = "0x18713E310")]
	public MONMJFCKPLO(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x713E100", Offset = "0x713D100", VA = "0x18713E100")]
	public void GEHFLMKLAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x713E090", Offset = "0x713D090", VA = "0x18713E090", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x713E030", Offset = "0x713D030", VA = "0x18713E030")]
	public static MONMJFCKPLO FGLFCCPLNMC(MONMJFCKPLO KPHAPKFFNPF, Action NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x713DFD0", Offset = "0x713CFD0", VA = "0x18713DFD0")]
	public static MONMJFCKPLO BACPEMDDOJO(MONMJFCKPLO KPHAPKFFNPF, Action NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IGBKFLCPOKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class OIDLICKKMBF<T> : BLCJCJJLNKL<Action<T>>, IGBKFLCPOKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public OIDLICKKMBF(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x25D9CA0", Offset = "0x25D8CA0", VA = "0x1825D9CA0")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x25D8760", Offset = "0x25D7760", VA = "0x1825D8760", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x25D6AD0", Offset = "0x25D5AD0", VA = "0x1825D6AD0")]
	public static OIDLICKKMBF<T> FGLFCCPLNMC(OIDLICKKMBF<T> KPHAPKFFNPF, Action<T> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x25D6A40", Offset = "0x25D5A40", VA = "0x1825D6A40")]
	public static OIDLICKKMBF<T> BACPEMDDOJO(OIDLICKKMBF<T> KPHAPKFFNPF, Action<T> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface APIAGKOPHHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T, U> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T, U> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EBFLMNLPKOJ<T, U> : BLCJCJJLNKL<Action<T, U>>, APIAGKOPHHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public EBFLMNLPKOJ(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27BE8E0", Offset = "0x27BD8E0", VA = "0x1827BE8E0")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN, U EFPGIMNOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x22A89A0", Offset = "0x22A79A0", VA = "0x1822A89A0", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x22A8910", Offset = "0x22A7910", VA = "0x1822A8910")]
	public static EBFLMNLPKOJ<T, U> FGLFCCPLNMC(EBFLMNLPKOJ<T, U> KPHAPKFFNPF, Action<T, U> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x22A8880", Offset = "0x22A7880", VA = "0x1822A8880")]
	public static EBFLMNLPKOJ<T, U> BACPEMDDOJO(EBFLMNLPKOJ<T, U> KPHAPKFFNPF, Action<T, U> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CNGJPLLKNEB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T, U, V> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T, U, V> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IAEDOANCKIC<T, U, V> : BLCJCJJLNKL<Action<T, U, V>>, CNGJPLLKNEB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public IAEDOANCKIC(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x184F200", Offset = "0x184E200", VA = "0x18184F200")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN, U EFPGIMNOJJI, V APFENMFKDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x184B870", Offset = "0x184A870", VA = "0x18184B870", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x184B300", Offset = "0x184A300", VA = "0x18184B300")]
	public static IAEDOANCKIC<T, U, V> FGLFCCPLNMC(IAEDOANCKIC<T, U, V> KPHAPKFFNPF, Action<T, U, V> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x184B270", Offset = "0x184A270", VA = "0x18184B270")]
	public static IAEDOANCKIC<T, U, V> BACPEMDDOJO(IAEDOANCKIC<T, U, V> KPHAPKFFNPF, Action<T, U, V> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NKMJJNAAKCK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T, U, V, W> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T, U, V, W> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class APOONAOLHGC<T, U, V, W> : BLCJCJJLNKL<Action<T, U, V, W>>, NKMJJNAAKCK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public APOONAOLHGC(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x206BA90", Offset = "0x206AA90", VA = "0x18206BA90")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN, U EFPGIMNOJJI, V APFENMFKDDO, W GMBJDLPGFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x206ABE0", Offset = "0x2069BE0", VA = "0x18206ABE0", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x206A270", Offset = "0x2069270", VA = "0x18206A270")]
	public static APOONAOLHGC<T, U, V, W> FGLFCCPLNMC(APOONAOLHGC<T, U, V, W> KPHAPKFFNPF, Action<T, U, V, W> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x206A1E0", Offset = "0x20691E0", VA = "0x18206A1E0")]
	public static APOONAOLHGC<T, U, V, W> BACPEMDDOJO(APOONAOLHGC<T, U, V, W> KPHAPKFFNPF, Action<T, U, V, W> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BMHNKGMCGBJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T, U, V, W, X> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T, U, V, W, X> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class NBHGNLPLHIN<T, U, V, W, X> : BLCJCJJLNKL<Action<T, U, V, W, X>>, BMHNKGMCGBJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public NBHGNLPLHIN(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2872550", Offset = "0x2871550", VA = "0x182872550")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN, U EFPGIMNOJJI, V APFENMFKDDO, W GMBJDLPGFAF, X LMFGBCIIJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2871B00", Offset = "0x2870B00", VA = "0x182871B00", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2871A70", Offset = "0x2870A70", VA = "0x182871A70")]
	public static NBHGNLPLHIN<T, U, V, W, X> FGLFCCPLNMC(NBHGNLPLHIN<T, U, V, W, X> KPHAPKFFNPF, Action<T, U, V, W, X> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x28719E0", Offset = "0x28709E0", VA = "0x1828719E0")]
	public static NBHGNLPLHIN<T, U, V, W, X> BACPEMDDOJO(NBHGNLPLHIN<T, U, V, W, X> KPHAPKFFNPF, Action<T, U, V, W, X> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MKPEPCBOJJJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKDPLFKFCJN(Action<T, U, V, W, X, Y> NPNCNABHINE, bool AHDBJDGNHKC = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBPDDHHFGHN(Action<T, U, V, W, X, Y> NPNCNABHINE);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class FKCJKGLCHMC<T, U, V, W, X, Y> : BLCJCJJLNKL<Action<T, U, V, W, X, Y>>, MKPEPCBOJJJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x184F470", Offset = "0x184E470", VA = "0x18184F470")]
	public FKCJKGLCHMC(bool AGOIIBKJOPP = false, bool JEBCOPPDHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x409C480", Offset = "0x409B480", VA = "0x18409C480")]
	public void GEHFLMKLAJC(T DIIOIJOPPCN, U EFPGIMNOJJI, V APFENMFKDDO, W GMBJDLPGFAF, X LMFGBCIIJHA, Y FPHLKKGCLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x409B8B0", Offset = "0x409A8B0", VA = "0x18409B8B0", Slot = "4")]
	public override void FMHGLEIEAAO(object[] JMLOLLOGKEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x409B820", Offset = "0x409A820", VA = "0x18409B820")]
	public static FKCJKGLCHMC<T, U, V, W, X, Y> FGLFCCPLNMC(FKCJKGLCHMC<T, U, V, W, X, Y> KPHAPKFFNPF, Action<T, U, V, W, X, Y> NPNCNABHINE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x409B790", Offset = "0x409A790", VA = "0x18409B790")]
	public static FKCJKGLCHMC<T, U, V, W, X, Y> BACPEMDDOJO(FKCJKGLCHMC<T, U, V, W, X, Y> KPHAPKFFNPF, Action<T, U, V, W, X, Y> NPNCNABHINE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KECPDGBJHOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MFEALGGNPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int KJJIHKKJKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int BCALFEDBPAM;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1F55AD0", Offset = "0x1F54AD0", VA = "0x181F55AD0")]
	private KECPDGBJHOO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DPMOAGKJEAL, int OENEHHHFHHL, int LPPIJDOEJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2323AD0", Offset = "0x2322AD0", VA = "0x182323AD0")]
	public static KECPDGBJHOO<T> CECGBIGMPDN()
	{
		return default(KECPDGBJHOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2323BC0", Offset = "0x2322BC0", VA = "0x182323BC0")]
	public (int, int, Task<T>) HPABMHCPEIO(int KKCEGKAKKII, [Optional] CancellationToken AOAEIGNDKPI, double PHEFFDENMLF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2324FF0", Offset = "0x2323FF0", VA = "0x182324FF0")]
	public void KGEOKONAAIA(int KKCEGKAKKII, int LPPIJDOEJDI, in T MLAOHBBKEKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GKDPPFOHOPC
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x713AE30", Offset = "0x7139E30", VA = "0x18713AE30")]
	public static KECPDGBJHOO<OKHGFHBPFAA> CECGBIGMPDN()
	{
		return default(KECPDGBJHOO<OKHGFHBPFAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x713AE80", Offset = "0x7139E80", VA = "0x18713AE80")]
	public static void KGEOKONAAIA(this in KECPDGBJHOO<OKHGFHBPFAA> DPHICODLGJD, int KKCEGKAKKII, int LPPIJDOEJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DefaultMember("Item")]
public class NEKABHLNBGL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, TVal> DAIFAAFDLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<TVal, TKey> MNJKPMELBIB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1C59E30", Offset = "0x1C58E30", VA = "0x181C59E30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> LCJBBPEAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x24F83D0", Offset = "0x24F73D0", VA = "0x1824F83D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> FEPFIPKLADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1858330", Offset = "0x1857330", VA = "0x181858330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2CAED20", Offset = "0x2CADD20", VA = "0x182CAED20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2CAEDC0", Offset = "0x2CADDC0", VA = "0x182CAEDC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2CADB40", Offset = "0x2CACB40", VA = "0x182CADB40")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE040", Offset = "0x2CAD040", VA = "0x182CAE040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2CADC20", Offset = "0x2CACC20", VA = "0x182CADC20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEBB0", Offset = "0x2CADBB0", VA = "0x182CAEBB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2CADA60", Offset = "0x2CACA60", VA = "0x182CADA60", Slot = "9")]
	public void Add(TKey CDBHHMNALJL, TVal CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2CADA20", Offset = "0x2CACA20", VA = "0x182CADA20", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2CADC80", Offset = "0x2CACC80", VA = "0x182CADC80", Slot = "8")]
	public bool ContainsKey(TKey CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2CADCE0", Offset = "0x2CACCE0", VA = "0x182CADCE0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEA80", Offset = "0x2CADA80", VA = "0x182CAEA80", Slot = "10")]
	public bool Remove(TKey CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEAB0", Offset = "0x2CADAB0", VA = "0x182CAEAB0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEC00", Offset = "0x2CADC00", VA = "0x182CAEC00", Slot = "11")]
	public bool TryGetValue(TKey CDBHHMNALJL, out TVal CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2C33F60", Offset = "0x2C32F60", VA = "0x182C33F60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2CADD10", Offset = "0x2CACD10", VA = "0x182CADD10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE740", Offset = "0x2CAD740", VA = "0x182CAE740")]
	public void KKDPLFKFCJN(TVal PCKJKBNEEPE, TKey CDBHHMNALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE650", Offset = "0x2CAD650", VA = "0x182CAE650")]
	public void KKDPLFKFCJN(KeyValuePair<TVal, TKey> GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2CADBE0", Offset = "0x2CACBE0", VA = "0x182CADBE0")]
	public bool CNEJNLOPMGC(TVal CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2CADF20", Offset = "0x2CACF20", VA = "0x182CADF20")]
	public bool FCOLACKIJCJ(KeyValuePair<TVal, TKey> GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE5E0", Offset = "0x2CAD5E0", VA = "0x182CAE5E0")]
	public bool HBPDDHHFGHN(TVal CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE5E0", Offset = "0x2CAD5E0", VA = "0x182CAE5E0")]
	public bool HBPDDHHFGHN(KeyValuePair<TVal, TKey> GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2CADAD0", Offset = "0x2CACAD0", VA = "0x182CADAD0")]
	public bool BBJOPJDJGON(TVal CDBHHMNALJL, out TKey CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE7C0", Offset = "0x2CAD7C0", VA = "0x182CAE7C0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> LOCDLLJFCDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2CADD70", Offset = "0x2CACD70", VA = "0x182CADD70")]
	private void DMHHOHPPEDP(TKey CDBHHMNALJL, TVal PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE8D0", Offset = "0x2CAD8D0", VA = "0x182CAE8D0")]
	private void ODGKHJPEMFH(TKey CDBHHMNALJL, TVal PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE2C0", Offset = "0x2CAD2C0", VA = "0x182CAE2C0")]
	private bool FGKPJEHMAAP(TKey CDBHHMNALJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE450", Offset = "0x2CAD450", VA = "0x182CAE450")]
	private bool FGKPJEHMAAP(TVal PCKJKBNEEPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEC30", Offset = "0x2CADC30", VA = "0x182CAEC30")]
	public NEKABHLNBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class ILLJBOFKCKJ<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<Internal, External> LAEELJKCOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Func<External, Internal> MLCJFIAAMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IList<Internal> IHMGNIOOIJN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> HKAGGJPAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x944420", Offset = "0x943420", VA = "0x180944420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x245CA50", Offset = "0x245BA50", VA = "0x18245CA50", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x245CAF0", Offset = "0x245BAF0", VA = "0x18245CAF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x245C9F0", Offset = "0x245B9F0", VA = "0x18245C9F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x245C960", Offset = "0x245B960", VA = "0x18245C960")]
	public ILLJBOFKCKJ(Func<Internal, External> LAEELJKCOII, Func<External, Internal> MLCJFIAAMJF, bool FCPNEDMPJPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x245C690", Offset = "0x245B690", VA = "0x18245C690", Slot = "6")]
	public int IndexOf(External GDMNFPEECEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x245C320", Offset = "0x245B320", VA = "0x18245C320", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x245C380", Offset = "0x245B380", VA = "0x18245C380", Slot = "13")]
	public bool Contains(External GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x245C410", Offset = "0x245B410", VA = "0x18245C410", Slot = "14")]
	public void CopyTo(External[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x245C240", Offset = "0x245B240", VA = "0x18245C240", Slot = "11")]
	public void Add(External GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x245C770", Offset = "0x245B770", VA = "0x18245C770", Slot = "7")]
	public void Insert(int EJNMEMKEIOD, External GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x245C8D0", Offset = "0x245B8D0", VA = "0x18245C8D0", Slot = "15")]
	public bool Remove(External GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x245C810", Offset = "0x245B810", VA = "0x18245C810", Slot = "8")]
	public void RemoveAt(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x245C620", Offset = "0x245B620", VA = "0x18245C620", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x13561E0", Offset = "0x13551E0", VA = "0x1813561E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class IOCCLCIELEA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<Internal, External> LAEELJKCOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IReadOnlyList<Internal> IHMGNIOOIJN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> HKAGGJPAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ED80", Offset = "0x2A9DD80", VA = "0x182A9ED80", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ED20", Offset = "0x2A9DD20", VA = "0x182A9ED20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xEDE1E0", Offset = "0xEDD1E0", VA = "0x180EDE1E0")]
	public IOCCLCIELEA(Func<Internal, External> LAEELJKCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ECD0", Offset = "0x2A9DCD0", VA = "0x182A9ECD0")]
	public IOCCLCIELEA(IReadOnlyList<Internal> IHMGNIOOIJN, Func<Internal, External> LAEELJKCOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EAC0", Offset = "0x2A9DAC0", VA = "0x182A9EAC0")]
	public void IEPALCONJIK(External[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EA50", Offset = "0x2A9DA50", VA = "0x182A9EA50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1E69DD0", Offset = "0x1E68DD0", VA = "0x181E69DD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class ACNALLMKPFE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IReadOnlyList<Internal> IHMGNIOOIJN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> HKAGGJPAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3D54340", Offset = "0x3D53340", VA = "0x183D54340", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3D542E0", Offset = "0x3D532E0", VA = "0x183D542E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xEDE1E0", Offset = "0xEDD1E0", VA = "0x180EDE1E0")]
	public ACNALLMKPFE(IReadOnlyList<Internal> IHMGNIOOIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3D53FB0", Offset = "0x3D52FB0", VA = "0x183D53FB0")]
	public bool FCOLACKIJCJ(External GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3D540C0", Offset = "0x3D530C0", VA = "0x183D540C0")]
	public void IEPALCONJIK(External[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3D54050", Offset = "0x3D53050", VA = "0x183D54050", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x13561E0", Offset = "0x13551E0", VA = "0x1813561E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BNNDACMDCOH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> GDCGANAMPHD(TRequest NJAMEFJLMOC, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum LBFONHNLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class DOMCDHFOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const float LFAIEFDFBEC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TimeSpan DCDJILGKBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int HFLNOEOBIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LBFONHNLBPM IPHHCNEODPM;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly DOMCDHFOEFM FHJNMCMHCKN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float NNDFAADFDNG
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x38210F0", Offset = "0x38200F0", VA = "0x1838210F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan IHCFODCHOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3821240", Offset = "0x3820240", VA = "0x183821240")]
		public DOMCDHFOEFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct PCACHJMCCCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TRequest NJAMEFJLMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CancellationToken AOAEIGNDKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TaskCompletionSource<TResult> MLEHDPAHMOH;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x32D97F0", Offset = "0x32D87F0", VA = "0x1832D97F0")]
		public PCACHJMCCCG(TRequest NJAMEFJLMOC, TaskCompletionSource<TResult> MLEHDPAHMOH, CancellationToken AOAEIGNDKPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BBOCMCAPIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public BNNDACMDCOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public BBOCMCAPIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x53D3510", Offset = "0x53D2510", VA = "0x1853D3510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GHGIJHMOJNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BNNDACMDCOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private PCACHJMCCCG <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public GHGIJHMOJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x343BE00", Offset = "0x343AE00", VA = "0x18343BE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CancellationTokenSource JPDKCPPGFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<PCACHJMCCCG> HEGIKBDEHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DOMCDHFOEFM BMPHBGGLCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly GDCGANAMPHD BEIMMDLAKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Task LKOKIENNCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int CHGHKCFGPJB;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2642B20", Offset = "0x2641B20", VA = "0x182642B20")]
	public BNNDACMDCOH(GDCGANAMPHD BEIMMDLAKBF, [Optional] DOMCDHFOEFM BMPHBGGLCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x26414A0", Offset = "0x26404A0", VA = "0x1826414A0")]
	public Task<TResult> ANLAMHJEBJD(TRequest NJAMEFJLMOC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x26423A0", Offset = "0x26413A0", VA = "0x1826423A0")]
	private void EPKLFMEDDMF(PCACHJMCCCG DBAMPEIBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26426C0", Offset = "0x26416C0", VA = "0x1826426C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNNDACMDCOH<, >.BBOCMCAPIMM))]
	private Task OGMBFMEFAHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2641840", Offset = "0x2640840", VA = "0x182641840")]
	private PCACHJMCCCG EDAHLOHNEFP()
	{
		return default(PCACHJMCCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2642100", Offset = "0x2641100", VA = "0x182642100")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNNDACMDCOH<, >.GHGIJHMOJNP))]
	private Task EEJOGDHPNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x26411D0", Offset = "0x26401D0", VA = "0x1826411D0")]
	private void AFJDFNALPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2641800", Offset = "0x2640800", VA = "0x182641800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HODGIILMBEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JGLMJEOEGJB<T> : HODGIILMBEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool JLJJPDGNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string EILBBHKJBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGLMJEOEGJB<T> AELOGMHLEEJ(Action<T> DEPDPNNFFAB);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGLMJEOEGJB<T> DOIFOBDGCPH(Action<T> DEPDPNNFFAB);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JGLMJEOEGJB<T> NHDHGEOHLHC(Action<T, T> DNLOGMEEGHI);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGLMJEOEGJB<T> NFDDONBHDML(Action<T, T> DNLOGMEEGHI);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JGLMJEOEGJB<T> IDFIMMBCHEP(Action<string> OECAANMAGPP);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JGLMJEOEGJB<T> PDEKFNNGKPE(Action<string> OECAANMAGPP);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CFOAHADMIPD<T> : JGLMJEOEGJB<T>, HODGIILMBEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private EBFLMNLPKOJ<T, T> DNPPIIOHBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private OIDLICKKMBF<T> NFBKFDHGDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private OIDLICKKMBF<string> DAOKAGDGPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private string NAFECGLLOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private T MLAOHBBKEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool IAKLNPAGIKB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E00", Offset = "0x9A3E00", VA = "0x1809A4E00", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xEDC0B0", Offset = "0xEDB0B0", VA = "0x180EDC0B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JLJJPDGNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x93A750", Offset = "0x939750", VA = "0x18093A750", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string EILBBHKJBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA936E0", Offset = "0xA926E0", VA = "0x180A936E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9BC420", Offset = "0x9BB420", VA = "0x1809BC420", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x21721B0", Offset = "0x21711B0", VA = "0x1821721B0")]
	private void GGOJLLGJIAD(T KPMKPNDNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2172250", Offset = "0x2171250", VA = "0x182172250")]
	private void GPGHAJIJLGH(string FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2172440", Offset = "0x2171440", VA = "0x182172440")]
	public void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x21723F0", Offset = "0x21713F0", VA = "0x1821723F0", Slot = "6")]
	public JGLMJEOEGJB<T> NHDHGEOHLHC(Action<T, T> DNLOGMEEGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x21723A0", Offset = "0x21713A0", VA = "0x1821723A0", Slot = "7")]
	public JGLMJEOEGJB<T> NFDDONBHDML(Action<T, T> DNLOGMEEGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x21720D0", Offset = "0x21710D0", VA = "0x1821720D0", Slot = "4")]
	public JGLMJEOEGJB<T> AELOGMHLEEJ(Action<T> DNLOGMEEGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2172160", Offset = "0x2171160", VA = "0x182172160", Slot = "5")]
	public JGLMJEOEGJB<T> DOIFOBDGCPH(Action<T> DEPDPNNFFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2172300", Offset = "0x2171300", VA = "0x182172300", Slot = "8")]
	public JGLMJEOEGJB<T> IDFIMMBCHEP(Action<string> OECAANMAGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x21724F0", Offset = "0x21714F0", VA = "0x1821724F0", Slot = "9")]
	public JGLMJEOEGJB<T> PDEKFNNGKPE(Action<string> OECAANMAGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2172560", Offset = "0x2171560", VA = "0x182172560")]
	public CFOAHADMIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CCMNGLAPBLK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KCGNFFEELGG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public JGLMJEOEGJB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BIMBCAIOAGD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public KCGNFFEELGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FDC0", Offset = "0x1A3EDC0", VA = "0x181A3FDC0")]
		internal void AMALEDOCHJP(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A13620", Offset = "0x2A12620", VA = "0x182A13620")]
	public static LJAJHHFEMAM<T> CHKCIEMLHMA<T>(this JGLMJEOEGJB<T> BJICLDEFPFJ, Action<T> PAFCNGJPIGM)
	{
		return null;
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x245D7A0", Offset = "0x245C7A0", VA = "0x18245D7A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7092510", Offset = "0x7091510", VA = "0x187092510")]
		public SerializedGuid(in Guid AGKIPDJPNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x713FF10", Offset = "0x713EF10", VA = "0x18713FF10")]
		public static SerializedGuid MBEGDJPPCKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x713FE80", Offset = "0x713EE80", VA = "0x18713FE80")]
		public static SerializedGuid LGKEEOJBCMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x713FDF0", Offset = "0x713EDF0", VA = "0x18713FDF0")]
		public bool LADFHPMJJHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x70924E0", Offset = "0x70914E0", VA = "0x1870924E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x713FFA0", Offset = "0x713EFA0", VA = "0x18713FFA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x713FD60", Offset = "0x713ED60", VA = "0x18713FD60")]
		public bool IFDICNKLMIJ(in Guid AGKIPDJPNCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x713FBD0", Offset = "0x713EBD0", VA = "0x18713FBD0", Slot = "7")]
		public bool Equals(SerializedGuid JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x713FC80", Offset = "0x713EC80", VA = "0x18713FC80", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7092430", Offset = "0x7091430", VA = "0x187092430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7092270", Offset = "0x7091270", VA = "0x187092270", Slot = "6")]
		public int CompareTo(SerializedGuid JONIFABKCAI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IMGILGKEKCH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Type JFNMFAMOKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string EJBOGAENPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool LNCEGJEEBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool MNGCKLKCMDH;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x713B760", Offset = "0x713A760", VA = "0x18713B760")]
	public IMGILGKEKCH(Type AEKNIHPFNHL, string KELHMEAGEEF, bool JMDFCDFEPON = false, bool HNIOOEBDEHN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class KLPDJNMNIOB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<T> IHMGNIOOIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HashSet<T> KKAOOHBDCEG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1C59E30", Offset = "0x1C58E30", VA = "0x181C59E30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A6C0", Offset = "0x1E296C0", VA = "0x181E2A6C0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x35E7CB0", Offset = "0x35E6CB0", VA = "0x1835E7CB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x25DAB30", Offset = "0x25D9B30", VA = "0x1825DAB30", Slot = "11")]
	public void Add(T GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x35E7540", Offset = "0x35E6540", VA = "0x1835E7540")]
	public bool DOIKGLENCKK(T GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x35E7B40", Offset = "0x35E6B40", VA = "0x1835E7B40", Slot = "15")]
	public bool Remove(T GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x34FF450", Offset = "0x34FE450", VA = "0x1834FF450", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2180590", Offset = "0x217F590", VA = "0x182180590", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x35E7400", Offset = "0x35E6400", VA = "0x1835E7400", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790", Slot = "13")]
	public bool Contains(T GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x35E7460", Offset = "0x35E6460", VA = "0x1835E7460", Slot = "14")]
	public void CopyTo(T[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CAED60", Offset = "0x2CADD60", VA = "0x182CAED60", Slot = "6")]
	public int IndexOf(T GDMNFPEECEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x35E7780", Offset = "0x35E6780", VA = "0x1835E7780", Slot = "7")]
	public void Insert(int EJNMEMKEIOD, T GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x35E79E0", Offset = "0x35E69E0", VA = "0x1835E79E0", Slot = "8")]
	public void RemoveAt(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x35E75E0", Offset = "0x35E65E0", VA = "0x1835E75E0")]
	public void EMLAFPMEIFC(Predicate<T> MPGELOPFEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A84D70", Offset = "0x2A83D70", VA = "0x182A84D70")]
	public void JLPIHGCCKLF(Comparison<T> LFMMIECKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x35E7BC0", Offset = "0x35E6BC0", VA = "0x1835E7BC0")]
	public KLPDJNMNIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IGAHCMEEPPI
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x713B4B0", Offset = "0x713A4B0", VA = "0x18713B4B0")]
	public static Vector3 CCDIDEOGAFB(this GameObject IHNGPGNCBCG, float NJMCEOCENGM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class FAEBJDFBBKB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type JFNMFAMOKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string EJBOGAENPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool LNCEGJEEBGN;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x713A7F0", Offset = "0x71397F0", VA = "0x18713A7F0")]
	public FAEBJDFBBKB(Type AEKNIHPFNHL, string KELHMEAGEEF, bool JMDFCDFEPON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OGHCAFGFBOO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x713E670", Offset = "0x713D670", VA = "0x18713E670")]
	public OGHCAFGFBOO(string FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x713E5F0", Offset = "0x713D5F0", VA = "0x18713E5F0")]
	public OGHCAFGFBOO(string FANKIHBOOPE, Exception LBCOELDFNJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NBEKACLMKDE
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x713E5B0", Offset = "0x713D5B0", VA = "0x18713E5B0")]
	[NotNull]
	public static byte[] HFOLEFFNJOP(this POAIAHAEMLD JHEEGLHPJGN, byte[] NCDEEMHJBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x713E370", Offset = "0x713D370", VA = "0x18713E370")]
	[NotNull]
	public static byte[] HFOLEFFNJOP(this POAIAHAEMLD JHEEGLHPJGN, HashAlgorithmName OGEPKBLIBGD, byte[] NCDEEMHJBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface POAIAHAEMLD
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HCAPEIIEPID);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LMAPCMEKCLJ : POAIAHAEMLD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] HKHGCEKCIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[CanBeNull]
	byte[] KDOEIILBLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object JKAHOLBDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class KMACJMJDKBB
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MMHBMDCKHLN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x713DF50", Offset = "0x713CF50", VA = "0x18713DF50")]
		public MMHBMDCKHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x713DEF0", Offset = "0x713CEF0", VA = "0x18713DEF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const byte LAJNCHHDAGN = 1;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const byte INGNBJHOAIB = 0;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> BFPEPMIBBIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static bool AHINEDMNJML;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x234F5E0", Offset = "0x234E5E0", VA = "0x18234F5E0")]
	[Conditional("UNITY_EDITOR")]
	private static void NCCMFPBLMCE<T>(params T[] DNPLDDANBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x713C400", Offset = "0x713B400", VA = "0x18713C400")]
	public static IDisposable GMCOAMFKCAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x713C840", Offset = "0x713B840", VA = "0x18713C840")]
	public static void MJAMJFLGGAD(this IncrementalHash MEPCELACOCO, [CanBeNull] GameObject IHNGPGNCBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x234F510", Offset = "0x234E510", VA = "0x18234F510")]
	public static void MJAMJFLGGAD<T>(this IncrementalHash MEPCELACOCO, [CanBeNull] T LMOLNJNIDGC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x234F8D0", Offset = "0x234E8D0", VA = "0x18234F8D0")]
	public static void OCMIOGFKMPO<T>(this IncrementalHash MEPCELACOCO, [CanBeNull] T JHEEGLHPJGN) where T : POAIAHAEMLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x234F0C0", Offset = "0x234E0C0", VA = "0x18234F0C0")]
	public static void IHCGDCPPOIK<T>(this IncrementalHash MEPCELACOCO, [CanBeNull] IList<T> HHGKHOJJINB) where T : POAIAHAEMLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x713C140", Offset = "0x713B140", VA = "0x18713C140")]
	private static bool DDMEAHOODPG([CanBeNull] POAIAHAEMLD JHEEGLHPJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x713C990", Offset = "0x713B990", VA = "0x18713C990")]
	public static void NDJLCDPGAPG(this IncrementalHash HCAPEIIEPID, [CanBeNull] string OELNBNFOPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x713C670", Offset = "0x713B670", VA = "0x18713C670")]
	public static void MCHEILACJMF(this IncrementalHash HCAPEIIEPID, long KNCNFHJIOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x713C4A0", Offset = "0x713B4A0", VA = "0x18713C4A0")]
	public static void HDIHDMEKFPJ(this IncrementalHash HCAPEIIEPID, int FCIFIOFFLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x713BCD0", Offset = "0x713ACD0", VA = "0x18713BCD0")]
	public static void ADBJJEGLAIJ(this IncrementalHash HCAPEIIEPID, short KBACJGIPJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x713CBB0", Offset = "0x713BBB0", VA = "0x18713CBB0")]
	public static void PLCGPMPHLNE(this IncrementalHash HCAPEIIEPID, byte CHHKPCBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x713BF70", Offset = "0x713AF70", VA = "0x18713BF70")]
	public static void AMEKEAFOBLN(this IncrementalHash HCAPEIIEPID, bool JJLBNFMLPKI, bool FKBEKHGGDGK = false, bool EPKOLCGEJND = false, bool EBLGHPCHAKC = false, bool EBDPCFLLGMH = false, bool KOPDFFHGAEC = false, bool AKCMBIDECDN = false, bool LHLPOACCODO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x234E9D0", Offset = "0x234D9D0", VA = "0x18234E9D0")]
	public static void IGPJMKOICCB<T>(this IncrementalHash HCAPEIIEPID, T BIMNFCFHIKL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x713C930", Offset = "0x713B930", VA = "0x18713C930")]
	public static void NBMFAIEFPJB(this IncrementalHash HCAPEIIEPID, float FMIKHACDCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x713BF10", Offset = "0x713AF10", VA = "0x18713BF10")]
	public static void AGIAPEBMCFA(this IncrementalHash HCAPEIIEPID, double PMBHOPMBJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x713C1D0", Offset = "0x713B1D0", VA = "0x18713C1D0")]
	public static void EDAGJPCLINN(this IncrementalHash HCAPEIIEPID, ulong HBDKDCICMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x713CB50", Offset = "0x713BB50", VA = "0x18713CB50")]
	public static void PDDBMELFLJK(this IncrementalHash HCAPEIIEPID, uint DEOCCAPIJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x713BEA0", Offset = "0x713AEA0", VA = "0x18713BEA0")]
	public static void ADNDKANJPDA(this IncrementalHash HCAPEIIEPID, ushort BALIBDFANOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x713C9F0", Offset = "0x713B9F0", VA = "0x18713C9F0")]
	public static void NJEBIIMGNEE(this IncrementalHash HCAPEIIEPID, Vector3 CDMMAEINHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x713C240", Offset = "0x713B240", VA = "0x18713C240")]
	public static void EIMGIOMGLFP(this IncrementalHash HCAPEIIEPID, Quaternion BJIBAPGBOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GBEMGLGOBBK
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x713AD50", Offset = "0x7139D50", VA = "0x18713AD50")]
	[NotNull]
	public static byte[] HFOLEFFNJOP(this LMAPCMEKCLJ JHAOJOIAEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x713ACE0", Offset = "0x7139CE0", VA = "0x18713ACE0")]
	[NotNull]
	public static byte[] HFOLEFFNJOP(this LMAPCMEKCLJ JHAOJOIAEPP, HashAlgorithmName OGEPKBLIBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x713A9B0", Offset = "0x71399B0", VA = "0x18713A9B0")]
	public static bool GMBICGBGCCD([CanBeNull] this LMAPCMEKCLJ JHAOJOIAEPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x713AB40", Offset = "0x7139B40", VA = "0x18713AB40")]
	public static bool GMBICGBGCCD([CanBeNull] this LMAPCMEKCLJ JHAOJOIAEPP, out string NAFECGLLOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x713ADC0", Offset = "0x7139DC0", VA = "0x18713ADC0")]
	private static string ODMCPHADACC([CanBeNull] byte[] OFGEHNEOBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x713A890", Offset = "0x7139890", VA = "0x18713A890")]
	private static bool GAMJGONAAAD([NotNull] LMAPCMEKCLJ JHAOJOIAEPP, [CanBeNull] out byte[] AGEOFMIGCDC, [CanBeNull] out byte[] CNDFJPDDFJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class AJCOCAEBOKO<TTask, T> : ODFNIKOPOEL<T>, DCEOCCGJAAG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HIKIFNDMMDK
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public HIKIFNDMMDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1A4DBF0", Offset = "0x1A4CBF0", VA = "0x181A4DBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AJCOCAEBOKO<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public HIKIFNDMMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x30812A0", Offset = "0x30802A0", VA = "0x1830812A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AJCOCAEBOKO<, >.HIKIFNDMMDK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> KKFLGBALEHM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool HGGAJIMPFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Task<T> KMKKLLICGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly CancellationTokenSource KCHPCPEPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool PPEKOOOIOOG;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> LDKKGLGFCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task DPCLBFLPILA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LJAJHHFEMAM<T> EKPABIIJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FHJJKILLDME GLFCFAOKBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F52770", Offset = "0x1F51770", VA = "0x181F52770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool BLPCIPDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x35058F0", Offset = "0x35048F0", VA = "0x1835058F0")]
	static AJCOCAEBOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3505C50", Offset = "0x3504C50", VA = "0x183505C50")]
	protected AJCOCAEBOKO(TTask KMKKLLICGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3505880", Offset = "0x3504880", VA = "0x183505880", Slot = "1")]
	~AJCOCAEBOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3505850", Offset = "0x3504850", VA = "0x183505850", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x35054B0", Offset = "0x35044B0", VA = "0x1835054B0")]
	private void BHAMNPKBJIA(bool ENIGPLEKCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T AFIFJMEKNKD(TTask KAJOBONJCPM);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OFEJGFAAEPP();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HAJOHPGDJHP : NBBPAOPLHOB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x713B370", Offset = "0x713A370", VA = "0x18713B370")]
	public HAJOHPGDJHP(Exception LDCEOCMADFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NBBPAOPLHOB<T> : ODFNIKOPOEL<T>, DCEOCCGJAAG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> LDKKGLGFCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task DPCLBFLPILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD87EA0", Offset = "0xD86EA0", VA = "0x180D87EA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public LJAJHHFEMAM<T> EKPABIIJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private FHJJKILLDME GLFCFAOKBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9BBA30", Offset = "0x9BAA30", VA = "0x1809BBA30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x28651D0", Offset = "0x28641D0", VA = "0x1828651D0")]
	public NBBPAOPLHOB(Exception LDCEOCMADFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface DCEOCCGJAAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task LDKKGLGFCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	FHJJKILLDME EKPABIIJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface ODFNIKOPOEL<T> : DCEOCCGJAAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> LDKKGLGFCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new LJAJHHFEMAM<T> EKPABIIJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class BNBLKGIDMDD : EPLDLHHEONB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x713A540", Offset = "0x7139540", VA = "0x18713A540")]
	public BNBLKGIDMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EPLDLHHEONB<T> : ODFNIKOPOEL<T>, DCEOCCGJAAG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> LDKKGLGFCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task DPCLBFLPILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD87EA0", Offset = "0xD86EA0", VA = "0x180D87EA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LJAJHHFEMAM<T> EKPABIIJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private FHJJKILLDME GLFCFAOKBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9BBA30", Offset = "0x9BAA30", VA = "0x1809BBA30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1361450", Offset = "0x1360450", VA = "0x181361450")]
	public EPLDLHHEONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class KNFCNAAJFDG : GLHOFFEBKJL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class KFJMENGBKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<KNFCNAAJFDG, FACALIAHOGE> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KFJMENGBKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x713B8E0", Offset = "0x713A8E0", VA = "0x18713B8E0")]
		internal void GIILBEFOFCM(GLHOFFEBKJL<string> timer, FACALIAHOGE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x713CF00", Offset = "0x713BF00", VA = "0x18713CF00")]
	public KNFCNAAJFDG(FACALIAHOGE IHHCPPEACEL, [Optional] string OHLDNCMHLIH, [Optional] int? DHELGLOEHDE, [Optional] Stopwatch BKPCKGDEGMJ, [Optional] Action<string, EAJKHLBIIEG, FACALIAHOGE> GIKPOPGLKPN, [Optional] Action<string, EAJKHLBIIEG, FACALIAHOGE> AKLMAJNDDLG, [Optional] Action<KNFCNAAJFDG, FACALIAHOGE> LAKNINKIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x713CE20", Offset = "0x713BE20", VA = "0x18713CE20")]
	private static Action<GLHOFFEBKJL<string>, FACALIAHOGE> IKIPFFDIENK(Action<KNFCNAAJFDG, FACALIAHOGE> PAFCNGJPIGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CJMHLPCJNFM<TKey> : NJMKECPHGFB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GILPDNILFDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public MPKOOLBHLLP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public GILPDNILFDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x13517D0", Offset = "0x13507D0", VA = "0x1813517D0")]
		internal string BCDOCFMIHBO(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2180830", Offset = "0x217F830", VA = "0x182180830", Slot = "5")]
	protected override string IGIKPIMHABC(GLHOFFEBKJL<TKey> IMDANOAGPHH, MPKOOLBHLLP LIILEODPCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2181110", Offset = "0x2180110", VA = "0x182181110")]
	public CJMHLPCJNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MCGPMOCJCFK<TKey> : MNDPFNBNOAO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate string KIGKHEGAEDE(TKey CDBHHMNALJL);

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const int JGEKHPHFPOG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly string DMADLJPNFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly double KHNKMHLIHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool DBOHOKKNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly int ABGLBHPBDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly ISet<string> GHOHONPHBAI;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x29DACA0", Offset = "0x29D9CA0", VA = "0x1829DACA0")]
	private static string DAFDILOJINM(TKey CDBHHMNALJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x29DB6E0", Offset = "0x29DA6E0", VA = "0x1829DB6E0")]
	public MCGPMOCJCFK(string DMADLJPNFAP = "F2", double KHNKMHLIHFI = double.MaxValue, bool DBOHOKKNCCK = false, int ABGLBHPBDHL = int.MaxValue, [Optional] ISet<string> GHOHONPHBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x29DADC0", Offset = "0x29D9DC0", VA = "0x1829DADC0", Slot = "4")]
	public override Dictionary<string, string> GIBAKBNMAHH(GLHOFFEBKJL<TKey> IMDANOAGPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x29DACE0", Offset = "0x29D9CE0", VA = "0x1829DACE0")]
	private bool DKPBPKOGAMK(string LMNOGNMFBNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x29DAE70", Offset = "0x29D9E70", VA = "0x1829DAE70")]
	public Dictionary<string, string> GIBAKBNMAHH(GLHOFFEBKJL<TKey> IMDANOAGPHH, KIGKHEGAEDE LIILEODPCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x29DB530", Offset = "0x29DA530", VA = "0x1829DB530")]
	private string NAFHHPGNDAG(StringBuilder PEEGHICNHKJ, List<TKey> NIFOKNLGBJP, KIGKHEGAEDE LIILEODPCEE, bool CGEPFBEGMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x29DB3B0", Offset = "0x29DA3B0", VA = "0x1829DB3B0")]
	private static void MLGGLEKCJEP(StringBuilder IEMJHPKBINF, string AAIIDOCLIPA, bool KMNBHLBLHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class MNDPFNBNOAO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GIBAKBNMAHH(GLHOFFEBKJL<TKey> IMDANOAGPHH);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
	protected MNDPFNBNOAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class NJMKECPHGFB<TKey> : MNDPFNBNOAO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string MPKOOLBHLLP(TKey CDBHHMNALJL);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74A00", Offset = "0x2A73A00", VA = "0x182A74A00")]
	protected string HMANEEPCOCC(double BOECHGHEMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2A747C0", Offset = "0x2A737C0", VA = "0x182A747C0")]
	protected string FODOINPHMHD(int IOOMJCHPBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2A74780", Offset = "0x2A73780", VA = "0x182A74780")]
	private static string DAFDILOJINM(TKey CDBHHMNALJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2A74950", Offset = "0x2A73950", VA = "0x182A74950", Slot = "4")]
	public override string GIBAKBNMAHH(GLHOFFEBKJL<TKey> IMDANOAGPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2A74820", Offset = "0x2A73820", VA = "0x182A74820")]
	public string GIBAKBNMAHH(GLHOFFEBKJL<TKey> IMDANOAGPHH, [NotNull] MPKOOLBHLLP LIILEODPCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string IGIKPIMHABC(GLHOFFEBKJL<TKey> IMDANOAGPHH, [NotNull] MPKOOLBHLLP LIILEODPCEE);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x13561E0", Offset = "0x13551E0", VA = "0x1813561E0")]
	protected NJMKECPHGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class KHECJJCKCKF
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class KIPIFHLKGAG : KHECJJCKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static KHECJJCKCKF PCFKPPACGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x713BB10", Offset = "0x713AB10", VA = "0x18713BB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime JOOJBOHKGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x713BB80", Offset = "0x713AB80", VA = "0x18713BB80", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float JIGMIGLILGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x713BB70", Offset = "0x713AB70", VA = "0x18713BB70", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x713BC70", Offset = "0x713AC70", VA = "0x18713BC70")]
		public KIPIFHLKGAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static KHECJJCKCKF CNEMOLNLKIM;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static KHECJJCKCKF FHJNMCMHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x713B980", Offset = "0x713A980", VA = "0x18713B980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime JOOJBOHKGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float JIGMIGLILGE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	protected KHECJJCKCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OCODINHEMME<TKey> : NJMKECPHGFB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PBPPJHILKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public MPKOOLBHLLP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static OCODINHEMME<TKey> PCFKPPACGDB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private const int KGDHNKGKNJD = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly string[] HECBBNCKFNM;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2C26E50", Offset = "0x2C25E50", VA = "0x182C26E50")]
	private OCODINHEMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2C25DA0", Offset = "0x2C24DA0", VA = "0x182C25DA0", Slot = "5")]
	protected override string IGIKPIMHABC(GLHOFFEBKJL<TKey> IMDANOAGPHH, MPKOOLBHLLP LIILEODPCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2C26C70", Offset = "0x2C25C70", VA = "0x182C26C70")]
	[CompilerGenerated]
	internal static string KHLBLMNGDLK(string EEDMENIHFHP, TKey CDBHHMNALJL, ref PBPPJHILKAD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GLHOFFEBKJL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct EAJKHLBIIEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly long BLIELNJAJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly long PPAFBMEEHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly int DHELGLOEHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly int CPJJMMCCCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly bool AJGBCBDHCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string CIPJFGGIODJ;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x22A6580", Offset = "0x22A5580", VA = "0x1822A6580")]
		public EAJKHLBIIEG(long BLIELNJAJMG, int DHELGLOEHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x22A65F0", Offset = "0x22A55F0", VA = "0x1822A65F0")]
		public EAJKHLBIIEG(long BLIELNJAJMG, long PPAFBMEEHPG, int DHELGLOEHDE, int CPJJMMCCCKL, bool AJGBCBDHCND, string CIPJFGGIODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x22A63F0", Offset = "0x22A53F0", VA = "0x1822A63F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void HKDFDMOGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x22A6470", Offset = "0x22A5470", VA = "0x1822A6470")]
		public int JMNPJIFNEOK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x22A63D0", Offset = "0x22A53D0", VA = "0x1822A63D0")]
		public int GIEFMCKBJLB(int NKBLDOGHFBA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x22A6360", Offset = "0x22A5360", VA = "0x1822A6360")]
		public double DLHFCNKCFKH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x22A64C0", Offset = "0x22A54C0", VA = "0x1822A64C0")]
		public EAJKHLBIIEG MPDCKOIIGJM(long PPAFBMEEHPG, int CPJJMMCCCKL)
		{
			return default(EAJKHLBIIEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class OADOKMKENLA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class DAKBLENFNOH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<OADOKMKENLA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public OADOKMKENLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private OADOKMKENLA <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public DAKBLENFNOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2E1DF10", Offset = "0x2E1CF10", VA = "0x182E1DF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly TKey JKINMNJLFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly GLHOFFEBKJL<TKey> IMDANOAGPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly FACALIAHOGE IHHCPPEACEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private List<OADOKMKENLA> MLJINMJPICG;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string ECFHECJKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xEDF480", Offset = "0xEDE480", VA = "0x180EDF480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x21D6DA0", Offset = "0x21D5DA0", VA = "0x1821D6DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<OADOKMKENLA> JFOFPJFPFIA
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x21D7250", Offset = "0x21D6250", VA = "0x1821D7250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public EAJKHLBIIEG HHNMAACJLCL
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x21D70E0", Offset = "0x21D60E0", VA = "0x1821D70E0")]
			[CompilerGenerated]
			get
			{
				return default(EAJKHLBIIEG);
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x21D70B0", Offset = "0x21D60B0", VA = "0x1821D70B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x21D7270", Offset = "0x21D6270", VA = "0x1821D7270")]
		internal OADOKMKENLA(GLHOFFEBKJL<TKey> IMDANOAGPHH, TKey CDBHHMNALJL, FACALIAHOGE IHHCPPEACEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x21D7100", Offset = "0x21D6100", VA = "0x1821D7100")]
		public OADOKMKENLA MOJEJICKLHA(TKey CDBHHMNALJL, [Optional] FACALIAHOGE? DKMBDHINAPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x21D6F80", Offset = "0x21D5F80", VA = "0x1821D6F80")]
		public void IKIPFFDIENK(TKey CDBHHMNALJL, Action<OADOKMKENLA> NPNCNABHINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2B813C0", Offset = "0x2B803C0", VA = "0x182B813C0")]
		public T IKIPFFDIENK<T>(TKey CDBHHMNALJL, Func<OADOKMKENLA, T> DGLOJMONMHM)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2B81200", Offset = "0x2B80200", VA = "0x182B81200")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DAKBLENFNOH<>))]
		public Task<T> EFGCEMHPGKJ<T>(TKey CDBHHMNALJL, Func<OADOKMKENLA, Task<T>> DGLOJMONMHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x21D6DD0", Offset = "0x21D5DD0", VA = "0x1821D6DD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class HFMJHDGNGFP : IEnumerable<(TKey, List<TKey>, EAJKHLBIIEG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EAJKHLBIIEG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, EAJKHLBIIEG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public GLHOFFEBKJL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IEnumerator<(TKey key, List<TKey> path, EAJKHLBIIEG timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private (TKey key, List<TKey> path, EAJKHLBIIEG timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, EAJKHLBIIEG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x3075670", Offset = "0x3074670", VA = "0x183075670", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EAJKHLBIIEG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x30756E0", Offset = "0x30746E0", VA = "0x1830756E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3075740", Offset = "0x3074740", VA = "0x183075740")]
		[DebuggerHidden]
		public HFMJHDGNGFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EAF0", Offset = "0x1E6DAF0", VA = "0x181E6EAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3075280", Offset = "0x3074280", VA = "0x183075280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3075230", Offset = "0x3074230", VA = "0x183075230")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x30756A0", Offset = "0x30746A0", VA = "0x1830756A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x30755B0", Offset = "0x30745B0", VA = "0x1830755B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EAJKHLBIIEG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2342FA0", Offset = "0x2341FA0", VA = "0x182342FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class JBOCHGJIADG : IEnumerable<(TKey, List<TKey>, EAJKHLBIIEG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EAJKHLBIIEG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private (TKey key, List<TKey> path, EAJKHLBIIEG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private OADOKMKENLA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public OADOKMKENLA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public GLHOFFEBKJL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private IEnumerator<OADOKMKENLA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private OADOKMKENLA <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private IEnumerator<(TKey key, List<TKey> path, EAJKHLBIIEG timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private (TKey key, List<TKey> path, EAJKHLBIIEG timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, EAJKHLBIIEG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x3075670", Offset = "0x3074670", VA = "0x183075670", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EAJKHLBIIEG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x31D9330", Offset = "0x31D8330", VA = "0x1831D9330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3075740", Offset = "0x3074740", VA = "0x183075740")]
		[DebuggerHidden]
		public JBOCHGJIADG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x31D9390", Offset = "0x31D8390", VA = "0x1831D9390", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x31D8BA0", Offset = "0x31D7BA0", VA = "0x1831D8BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x31D8B40", Offset = "0x31D7B40", VA = "0x1831D8B40")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x31D91B0", Offset = "0x31D81B0", VA = "0x1831D91B0")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x31D92F0", Offset = "0x31D82F0", VA = "0x1831D92F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x31D9210", Offset = "0x31D8210", VA = "0x1831D9210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EAJKHLBIIEG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x245AF60", Offset = "0x2459F60", VA = "0x18245AF60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<TKey, EAJKHLBIIEG, FACALIAHOGE> GIKPOPGLKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action<TKey, EAJKHLBIIEG, FACALIAHOGE> AKLMAJNDDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Action<GLHOFFEBKJL<TKey>, FACALIAHOGE> LAKNINKIBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private const string PGOCHOAIECB = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly OADOKMKENLA FHDLFBBMAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool PPEKOOOIOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int OMECLKMABIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly Stopwatch BKPCKGDEGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly int CACBEDLGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string GPAKOAJHKNL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public OADOKMKENLA NDKJHCOOBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string ECFHECJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3447C30", Offset = "0x3446C30", VA = "0x183447C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long AJKKECLMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3447ED0", Offset = "0x3446ED0", VA = "0x183447ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int DINMCIEKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3447EA0", Offset = "0x3446EA0", VA = "0x183447EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3447F70", Offset = "0x3446F70", VA = "0x183447F70")]
	public GLHOFFEBKJL(TKey CIKHOLFOJOC, FACALIAHOGE IHHCPPEACEL, [Optional] int? DHELGLOEHDE, [Optional][CanBeNull] Stopwatch BKPCKGDEGMJ, [Optional] Action<TKey, EAJKHLBIIEG, FACALIAHOGE> GIKPOPGLKPN, [Optional] Action<TKey, EAJKHLBIIEG, FACALIAHOGE> AKLMAJNDDLG, [Optional] Action<GLHOFFEBKJL<TKey>, FACALIAHOGE> LAKNINKIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3447C90", Offset = "0x3446C90", VA = "0x183447C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3447E80", Offset = "0x3446E80", VA = "0x183447E80")]
	public void JDCFFOKEHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3447C10", Offset = "0x3446C10", VA = "0x183447C10")]
	public void AJJFIBNAEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3447DF0", Offset = "0x3446DF0", VA = "0x183447DF0")]
	[IteratorStateMachine(typeof(GLHOFFEBKJL<>.HFMJHDGNGFP))]
	public IEnumerable<(TKey, List<TKey>, EAJKHLBIIEG)> FLDODBGOEHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3447D20", Offset = "0x3446D20", VA = "0x183447D20")]
	[IteratorStateMachine(typeof(GLHOFFEBKJL<>.JBOCHGJIADG))]
	private IEnumerable<(TKey, List<TKey>, EAJKHLBIIEG)> FLDODBGOEHC(List<TKey> JAGGOBHOHJG, OADOKMKENLA HPADEJILBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3447EF0", Offset = "0x3446EF0", VA = "0x183447EF0")]
	private (long, int) PDIEOBELLHN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class LIGPCOLJPEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<byte, HAFHOOILFPE> AFDMBFCBOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly JLIFDFKCPFP<HAFHOOILFPE> EJCGHNDKMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly bool IOOOCEKMLMA;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HAFHOOILFPE GGLNLIMFAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 MIDOAKOEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x843660", Offset = "0x842660", VA = "0x180843660")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xC3CD70", Offset = "0xC3BD70", VA = "0x180C3CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 MBFAPBIEINM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FAE0", Offset = "0x1A3EAE0", VA = "0x181A3FAE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA9F750", Offset = "0xA9E750", VA = "0x180A9F750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 DNEKJCGDEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x713DA80", Offset = "0x713CA80", VA = "0x18713DA80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE56F80", Offset = "0xE55F80", VA = "0x180E56F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int NIEOGHPFFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9CC1C0", Offset = "0x9CB1C0", VA = "0x1809CC1C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xDE9520", Offset = "0xDE8520", VA = "0x180DE9520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x713DAA0", Offset = "0x713CAA0", VA = "0x18713DAA0")]
	public LIGPCOLJPEM(Bounds MOJNJLFHEGC, Vector2[] MBBJLCNNOGI, int KGKIENPBIBJ, byte GOKCMPDIEBG, float OOIFBLFBOLE = 0f, [Optional] JLIFDFKCPFP<HAFHOOILFPE> EJCGHNDKMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x713D110", Offset = "0x713C110", VA = "0x18713D110")]
	public HAFHOOILFPE CJINOGADGPC(byte EJNMEMKEIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x713D240", Offset = "0x713C240", VA = "0x18713D240")]
	public void JCNCPDODNPO(Vector3 EDEGPGKBEGA, float JAADLLAGLBJ, float EBFLENDEMHM, ref List<byte> BCNCMJJGFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x713D220", Offset = "0x713C220", VA = "0x18713D220")]
	public void JAFECMAMLKB(HAFHOOILFPE.BLJIDGGEELA FPECKLOOBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x713D060", Offset = "0x713C060", VA = "0x18713D060")]
	public static int BCOOCPMFIJJ(Vector2[] MBBJLCNNOGI, int KGKIENPBIBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x713D6F0", Offset = "0x713C6F0", VA = "0x18713D6F0")]
	private HAFHOOILFPE KJANHLLCDJM(byte EJNMEMKEIOD, HAFHOOILFPE.CIFEJHNLNBL AMGOHEBGCHA, HAFHOOILFPE AGFCJPGACCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x713D310", Offset = "0x713C310", VA = "0x18713D310")]
	private void JFKPIIDALHF(HAFHOOILFPE AGFCJPGACCB, Vector2[] MBBJLCNNOGI, int FDJAJNAPMLJ, int APDNLBLKKMC, int BCPMJNHBKFO, int JLHLCKMCPCC, float OOIFBLFBOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x713D880", Offset = "0x713C880", VA = "0x18713D880")]
	private void KJLJHIGIKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x713D170", Offset = "0x713C170", VA = "0x18713D170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x713D1D0", Offset = "0x713C1D0", VA = "0x18713D1D0", Slot = "1")]
	~LIGPCOLJPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HAFHOOILFPE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum CIFEJHNLNBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum BLJIDGGEELA
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte BHGLMOPPBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 LCFMPDGOPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 JELHAAPPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 LIFBPBGFKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 FOOIHABIJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public CIFEJHNLNBL FABLIJIBBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public HAFHOOILFPE PFNKNMFEFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public List<HAFHOOILFPE> JKMFKBFPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool MLBCMEHBBEC;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x713B350", Offset = "0x713A350", VA = "0x18713B350")]
	public HAFHOOILFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x713B2F0", Offset = "0x713A2F0", VA = "0x18713B2F0")]
	public HAFHOOILFPE(byte OACHBLHDAOM, CIFEJHNLNBL AMGOHEBGCHA, HAFHOOILFPE AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x713AF30", Offset = "0x7139F30", VA = "0x18713AF30")]
	public void DCILHALKLLL(HAFHOOILFPE CJCAJMJJJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public void JAFECMAMLKB(int GGFFHLGGMBD, BLJIDGGEELA FPECKLOOBGK, int EJOGMJAEGBN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x713AFF0", Offset = "0x7139FF0", VA = "0x18713AFF0")]
	public void JCNCPDODNPO(List<byte> BCNCMJJGFND, Vector3 EDEGPGKBEGA, float JAADLLAGLBJ, float EBFLENDEMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x713B2A0", Offset = "0x713A2A0", VA = "0x18713B2A0")]
	public bool KLDPIGCMCHG(Vector3 GDBJDNPJJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x713AF00", Offset = "0x7139F00", VA = "0x18713AF00")]
	public bool CFIPJPAFAGA(Vector3 GDBJDNPJJPO, float BLIPJFBBMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x713B220", Offset = "0x713A220", VA = "0x18713B220")]
	public void JFGMJMMFADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JLIFDFKCPFP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly Stack<T> DKGPHECDOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<T> KLLGDEOPAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly int FFGOBBIJKPN;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int EJMKDGIKJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xEDF480", Offset = "0xEDE480", VA = "0x180EDF480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int HDGNICNGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2AA27F0", Offset = "0x2AA17F0", VA = "0x182AA27F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x3A94070", Offset = "0x3A93070", VA = "0x183A94070")]
	public static JLIFDFKCPFP<T> ECHBGAOGDGO(int JEBBAFBPNEF = 0, int FFGOBBIJKPN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x3A93EB0", Offset = "0x3A92EB0", VA = "0x183A93EB0")]
	public static JLIFDFKCPFP<T> DIKKIEJPBJI(int JEBBAFBPNEF = 0, int FFGOBBIJKPN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3A945D0", Offset = "0x3A935D0", VA = "0x183A945D0")]
	public JLIFDFKCPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3A94440", Offset = "0x3A93440", VA = "0x183A94440")]
	public JLIFDFKCPFP(int JEBBAFBPNEF, int FFGOBBIJKPN = int.MaxValue, bool DKMPNCEJKPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3A94330", Offset = "0x3A93330", VA = "0x183A94330")]
	public T NCBGDAJJCEO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3A93C00", Offset = "0x3A92C00", VA = "0x183A93C00")]
	public void BCFCNGLDFNC(T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3A94140", Offset = "0x3A93140", VA = "0x183A94140")]
	private void EJFFACNNJCC(T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A93BE0", Offset = "0x3A92BE0", VA = "0x183A93BE0")]
	private void BBAOKPJIBHI(T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A942A0", Offset = "0x3A932A0", VA = "0x183A942A0")]
	[Conditional("DEBUG_BUILD")]
	private void JJGBOIHABDB(T NDNLCJBKNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A94210", Offset = "0x3A93210", VA = "0x183A94210")]
	[Conditional("DEBUG_BUILD")]
	private void HCMDPFDBMLC(T NDNLCJBKNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A93F80", Offset = "0x3A92F80", VA = "0x183A93F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A93CA0", Offset = "0x3A92CA0", VA = "0x183A93CA0")]
	private void COLFCPLMMHC(IEnumerable<T> JIBLOMPBADG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class AKGOMMPPGMF
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private enum KJCHCNHAJJF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int HCAPEIIEPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private bool NBLAMBPMHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private KJCHCNHAJJF EGNHEHPGBMN;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PELFLFHGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x713A3B0", Offset = "0x71393B0", VA = "0x18713A3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LADCBIMEDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7139E50", Offset = "0x7138E50", VA = "0x187139E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x713A3C0", Offset = "0x71393C0", VA = "0x18713A3C0")]
	public AKGOMMPPGMF(bool NBLAMBPMHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7139750", Offset = "0x7138750", VA = "0x187139750")]
	public void CDJIJABEDDB(object DCGPCJKHCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7139640", Offset = "0x7138640", VA = "0x187139640")]
	public void BBJPANEBKAH(int CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x713A240", Offset = "0x7139240", VA = "0x18713A240")]
	public void LPABHPHIBNL(uint APCFNGBCJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7139E60", Offset = "0x7138E60", VA = "0x187139E60")]
	public void IMMGPKEKDPF(bool HBEOFOFKBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x713A250", Offset = "0x7139250", VA = "0x18713A250")]
	public void MLFPNIPINHM(long ICIDIOBNBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7139E00", Offset = "0x7138E00", VA = "0x187139E00")]
	public void ECLGBJNCMPM(ulong GGOLBPGILAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x713A1D0", Offset = "0x71391D0", VA = "0x18713A1D0")]
	public void LKKLEDBOHPN(string PKIPELCJLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x71395B0", Offset = "0x71385B0", VA = "0x1871395B0")]
	public void BBBFOIHMAAK(Enum LDCEOCMADFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x713A290", Offset = "0x7139290", VA = "0x18713A290")]
	public void NIFAHNHANAM(IList IHMGNIOOIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A3EEB0", Offset = "0x2A3DEB0", VA = "0x182A3EEB0")]
	public void GPBOJEIIIKF<T, U>(Dictionary<T, U> KNLPMGADPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7139E80", Offset = "0x7138E80", VA = "0x187139E80")]
	private void JCOCACMANHP(IDictionary KNLPMGADPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x71396E0", Offset = "0x71386E0", VA = "0x1871396E0")]
	public int BGHLBJALEBN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7139D90", Offset = "0x7138D90", VA = "0x187139D90")]
	public short CFEOKCKLPEO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7139E40", Offset = "0x7138E40", VA = "0x187139E40")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7139540", Offset = "0x7138540", VA = "0x187139540")]
	private void AKCBMDOOIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface IPAOMOBPENH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ResourcePrefabReference<T> : IPAOMOBPENH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3C50", Offset = "0x2BB2C50", VA = "0x182BB3C50", Slot = "4")]
		public virtual T PFLOJKIJEEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class JBPLGEJIHGM<T> : IEnumerable<JBPLGEJIHGM<T>.GMOKJKFLIIJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct GMOKJKFLIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T CKMKMNKGMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int EJNMEMKEIOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class GHNBNAPGADP : IEnumerator<GMOKJKFLIIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private JBPLGEJIHGM<T> GFIGBIOJDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int EJNMEMKEIOD;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x9AFAB0", Offset = "0x9AEAB0", VA = "0x1809AFAB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GMOKJKFLIIJ DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x343C3E0", Offset = "0x343B3E0", VA = "0x18343C3E0", Slot = "4")]
			get
			{
				return default(GMOKJKFLIIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E4F240", Offset = "0x2E4E240", VA = "0x182E4F240")]
		public GHNBNAPGADP(JBPLGEJIHGM<T> GFIGBIOJDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x343C220", Offset = "0x343B220", VA = "0x18343C220", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x16F26A0", Offset = "0x16F16A0", VA = "0x1816F26A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xDB8830", Offset = "0xDB7830", VA = "0x180DB8830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct KJLOPDBAMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool BMNCAIGNCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public T CKMKMNKGMMC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private const int MLNFNIPNPAA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Dictionary<T, int> JKOBPGLHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private KJLOPDBAMBA[] EJJNNMBBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int PHMJHEDFNEG;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int LPPHJMCPCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA60", Offset = "0xA4CA60", VA = "0x180A4DA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2B0", Offset = "0xA4A2B0", VA = "0x180A4B2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1C59E30", Offset = "0x1C58E30", VA = "0x181C59E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x31DB070", Offset = "0x31DA070", VA = "0x1831DB070")]
	public JBPLGEJIHGM(int JEBBAFBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x31DAC80", Offset = "0x31D9C80", VA = "0x1831DAC80")]
	public JBPLGEJIHGM(GMOKJKFLIIJ[] PIGAGHHOGGP, bool MDLNEJBEOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x31DA0A0", Offset = "0x31D90A0", VA = "0x1831DA0A0")]
	public int GIGJBCCHKBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x31DA350", Offset = "0x31D9350", VA = "0x1831DA350")]
	private int LLHLAFFCCIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x31DA750", Offset = "0x31D9750", VA = "0x1831DA750", Slot = "6")]
	protected virtual uint MPGELMJLJAO(uint HCAPEIIEPID, T CKMKMNKGMMC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x31DA310", Offset = "0x31D9310", VA = "0x1831DA310")]
	public bool KIBMAJNELKD(T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x31DA270", Offset = "0x31D9270", VA = "0x1831DA270")]
	public bool KDAEOEOOIPL(int EJNMEMKEIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x31D9E00", Offset = "0x31D8E00", VA = "0x1831D9E00")]
	public bool FCOLACKIJCJ(Func<T, bool> IEEKCBEDONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x31DA7C0", Offset = "0x31D97C0", VA = "0x1831DA7C0")]
	public int NNEALAFMKCH(T CKMKMNKGMMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x31D96E0", Offset = "0x31D86E0", VA = "0x1831D96E0")]
	public T CHKCIEMLHMA(int EJNMEMKEIOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x31D9CD0", Offset = "0x31D8CD0", VA = "0x1831D9CD0")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x31D9A90", Offset = "0x31D8A90", VA = "0x1831D9A90")]
	public bool DOIKGLENCKK(T CKMKMNKGMMC, bool HINIDMEKKPG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D98A0", Offset = "0x31D88A0", VA = "0x1831D98A0")]
	public bool DOIKGLENCKK(T CKMKMNKGMMC, int EJNMEMKEIOD, bool HINIDMEKKPG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x31DA190", Offset = "0x31D9190", VA = "0x1831DA190")]
	public bool HBPDDHHFGHN(T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x31DA220", Offset = "0x31D9220", VA = "0x1831DA220")]
	public bool JDKMAIEIFCP(int EJNMEMKEIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x31D9ED0", Offset = "0x31D8ED0", VA = "0x1831D9ED0")]
	private void FGKPJEHMAAP(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x31D95A0", Offset = "0x31D85A0", VA = "0x1831D95A0")]
	public GMOKJKFLIIJ[] BCIJGOFCAEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x31D97D0", Offset = "0x31D87D0", VA = "0x1831D97D0")]
	private int CIIMDKHKIGM(int GOKCMPDIEBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x31DA820", Offset = "0x31D9820", VA = "0x1831DA820", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x31DA820", Offset = "0x31D9820", VA = "0x1831DA820", Slot = "4")]
	private IEnumerator<GMOKJKFLIIJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x713E8A0", Offset = "0x713D8A0", VA = "0x18713E8A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x713EB30", Offset = "0x713DB30", VA = "0x18713EB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x713EA60", Offset = "0x713DA60", VA = "0x18713EA60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x713EC80", Offset = "0x713DC80", VA = "0x18713EC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x713E810", Offset = "0x713D810", VA = "0x18713E810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x713EAA0", Offset = "0x713DAA0", VA = "0x18713EAA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x713E9D0", Offset = "0x713D9D0", VA = "0x18713E9D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x713E7B0", Offset = "0x713D7B0", VA = "0x18713E7B0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JOOOCHFHHDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int JEBBAFBPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int OHIODBIHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private List<T> KKCHKODIJBH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xEDF480", Offset = "0xEDE480", VA = "0x180EDF480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T GMDBILMCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x342E6F0", Offset = "0x342D6F0", VA = "0x18342E6F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IMJFKCMKKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x342E380", Offset = "0x342D380", VA = "0x18342E380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T PFPCACKFHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x342E7D0", Offset = "0x342D7D0", VA = "0x18342E7D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x342E830", Offset = "0x342D830", VA = "0x18342E830")]
	public JOOOCHFHHDJ(int JEBBAFBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x342E420", Offset = "0x342D420", VA = "0x18342E420")]
	public void KKDPLFKFCJN(T DDDEKMACFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x342E2F0", Offset = "0x342D2F0", VA = "0x18342E2F0")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x342E5D0", Offset = "0x342D5D0", VA = "0x18342E5D0")]
	public void LAAIBFLFMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x342E330", Offset = "0x342D330", VA = "0x18342E330")]
	public void IPFDLJPMEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x342E2E0", Offset = "0x342D2E0", VA = "0x18342E2E0")]
	public void EDHCNAKOBFK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public struct NNJNJNCAMLI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly List<Component> IHMGNIOOIJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly bool MCLPENLANDF;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xD9C0B0", Offset = "0xD9B0B0", VA = "0x180D9C0B0")]
			public NNJNJNCAMLI(List<Component> IHMGNIOOIJN, bool MCLPENLANDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2A80E40", Offset = "0x2A7FE40", VA = "0x182A80E40")]
			public DPPDLAPFPCO<T> DHFGGODEIOI()
			{
				return default(DPPDLAPFPCO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2A80EB0", Offset = "0x2A7FEB0", VA = "0x182A80EB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2A80EB0", Offset = "0x2A7FEB0", VA = "0x182A80EB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public struct DPPDLAPFPCO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly List<Component> IHMGNIOOIJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private readonly bool MCLPENLANDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int EJNMEMKEIOD;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T DALPLHLAAAJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x38222A0", Offset = "0x38212A0", VA = "0x1838222A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x3822230", Offset = "0x3821230", VA = "0x183822230", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x3822270", Offset = "0x3821270", VA = "0x183822270")]
			public DPPDLAPFPCO(List<Component> IHMGNIOOIJN, bool MCLPENLANDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x3822160", Offset = "0x3821160", VA = "0x183822160", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x3822170", Offset = "0x3821170", VA = "0x183822170", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x22A6A30", Offset = "0x22A5A30", VA = "0x1822A6A30", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x7140A10", Offset = "0x713FA10", VA = "0x187140A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x71409D0", Offset = "0x713F9D0", VA = "0x1871409D0")]
		public ToolHierarchyCache(GameObject IADMJGHOCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7140140", Offset = "0x713F140", VA = "0x187140140")]
		private void JFGMJMMFADK(GameObject IADMJGHOCPL, bool CAMEGMHBOIN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x71402B0", Offset = "0x713F2B0", VA = "0x1871402B0")]
		public static void JFGMJMMFADK(GameObject IADMJGHOCPL, ref ToolHierarchyCache JMFNDFLLKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7140410", Offset = "0x713F410", VA = "0x187140410")]
		public void NGIKLFMFGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x71403C0", Offset = "0x713F3C0", VA = "0x1871403C0")]
		public void MFMNKAMNLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D89380", Offset = "0x2D88380", VA = "0x182D89380")]
		public void CBOPOAEOOIO<T>(Action<T> NPNCNABHINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7140530", Offset = "0x713F530", VA = "0x187140530")]
		public Component OAMDFNAGLBN(Type FLAJIGGIBOB, bool MCLPENLANDF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D896E0", Offset = "0x2D886E0", VA = "0x182D896E0")]
		public T OAMDFNAGLBN<T>(bool MCLPENLANDF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7140340", Offset = "0x713F340", VA = "0x187140340")]
		public NNJNJNCAMLI<Component> MFIPFBICMMN(Type FLAJIGGIBOB, bool MCLPENLANDF = false)
		{
			return default(NNJNJNCAMLI<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D89610", Offset = "0x2D88610", VA = "0x182D89610")]
		public NNJNJNCAMLI<T> MFIPFBICMMN<T>(bool MCLPENLANDF = false) where T : class
		{
			return default(NNJNJNCAMLI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7140600", Offset = "0x713F600", VA = "0x187140600")]
		public List<Component> PADDJNIKKAI(Type FLAJIGGIBOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7140040", Offset = "0x713F040", VA = "0x187140040", Slot = "4")]
		public bool Equals(ToolHierarchyCache LMFGBCIIJHA, ToolHierarchyCache FPHLKKGCLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x71400C0", Offset = "0x713F0C0", VA = "0x1871400C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DCGPCJKHCOO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class NOODKHIANOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Dictionary<int, T> AINALLHHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private T LHHLOFAHEHG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T ALAFPEFEHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x978A80", Offset = "0x977A80", VA = "0x180978A80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool IKCFKIMIDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2A82040", Offset = "0x2A81040", VA = "0x182A82040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A81D50", Offset = "0x2A80D50", VA = "0x182A81D50")]
	public bool APLDHGMAGCD(T CKMKMNKGMMC, int AGNHICGKOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2A818D0", Offset = "0x2A808D0", VA = "0x182A818D0")]
	public bool AAMBGKOLHIL(int AGNHICGKOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A81930", Offset = "0x2A80930", VA = "0x182A81930")]
	public T AOBAFDBINHO(int ADKDFFEGDLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A81FE0", Offset = "0x2A80FE0", VA = "0x182A81FE0")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A81E40", Offset = "0x2A80E40", VA = "0x182A81E40")]
	private bool CHPJJOMKGPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A81E10", Offset = "0x2A80E10", VA = "0x182A81E10")]
	public bool BBJOPJDJGON(int AGNHICGKOFO, out T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2A82080", Offset = "0x2A81080", VA = "0x182A82080")]
	public NOODKHIANOK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9A6670", Offset = "0x9A5670", VA = "0x1809A6670")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int MBMAEEFDADD, int LPDDOLBOCMH]
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3EF61B0", Offset = "0x3EF51B0", VA = "0x183EF61B0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3EF6250", Offset = "0x3EF5250", VA = "0x183EF6250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6120", Offset = "0x3EF5120", VA = "0x183EF6120")]
		public Array2D(uint EHEJMPBLKPN, uint DCLLCCBGJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3EF60A0", Offset = "0x3EF50A0", VA = "0x183EF60A0")]
		public void EPCDHGCGJPK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x713A400", Offset = "0x7139400", VA = "0x18713A400")]
		public Array2DVector3(uint EHEJMPBLKPN, uint DCLLCCBGJBA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class GHNMEMFFNIH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class GOBFPLHGBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode DPHICODLGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TNode AGFCJPGACCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KCKONGGAAGH KAMALCLMCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public List<KCKONGGAAGH> CHICFDJCABE;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public GOBFPLHGBEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal struct KCKONGGAAGH : IComparable<KCKONGGAAGH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int AGNHICGKOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public TClaimant CBDBAGCKCGF;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE4A250", Offset = "0xE49250", VA = "0x180E4A250")]
		public KCKONGGAAGH(int AGNHICGKOFO, TClaimant CBDBAGCKCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1A466C0", Offset = "0x1A456C0", VA = "0x181A466C0")]
		public bool MGKHMBLEMIA(in KCKONGGAAGH JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1A466B0", Offset = "0x1A456B0", VA = "0x181A466B0")]
		public bool FKJDHGBFBOO(in KCKONGGAAGH JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1A466A0", Offset = "0x1A456A0", VA = "0x181A466A0", Slot = "4")]
		public int CompareTo(KCKONGGAAGH JONIFABKCAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1A46720", Offset = "0x1A45720", VA = "0x181A46720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum OCAMADFHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class JEOKMAJEJKD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GHNMEMFFNIH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public JEOKMAJEJKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x28FF4A0", Offset = "0x28FE4A0", VA = "0x1828FF4A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x28FF670", Offset = "0x28FE670", VA = "0x1828FF670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x28FF590", Offset = "0x28FE590", VA = "0x1828FF590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1859900", Offset = "0x1858900", VA = "0x181859900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly JLIFDFKCPFP<GOBFPLHGBEF> IBBDIBIMNNN;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly JLIFDFKCPFP<List<KCKONGGAAGH>> JPLABECNEMB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int OADJPLBJEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TClaimant, TNode> CKIMINPEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal readonly Dictionary<TNode, GOBFPLHGBEF> FHGKGOCGKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private OCAMADFHCPC MJDCPFELDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GPAHLJAOGGF(TNode NMNIBLLMCPD);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HEPOPOBHLDG(TNode NMNIBLLMCPD, TClaimant FLCMNHGAAJK, TClaimant PGMDEEAJBHO);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x343E7B0", Offset = "0x343D7B0", VA = "0x18343E7B0")]
	public GHNMEMFFNIH(OCAMADFHCPC MJDCPFELDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x343DAC0", Offset = "0x343CAC0", VA = "0x18343DAC0")]
	public void JNJOEEDFHGB(TNode NMNIBLLMCPD, TNode COLDPDBGEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x343E3C0", Offset = "0x343D3C0", VA = "0x18343E3C0")]
	public void OMFEMMOKNPB(TClaimant CBDBAGCKCGF, TNode OBLDHKJBNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x343D150", Offset = "0x343C150", VA = "0x18343D150", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x343D0B0", Offset = "0x343C0B0", VA = "0x18343D0B0")]
	private void DCAEAJEBACP(TClaimant CBDBAGCKCGF, TNode OJMHLCPEHDO, TNode OBLDHKJBNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x343DF10", Offset = "0x343CF10", VA = "0x18343DF10")]
	private int LCKEDNDEMFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x343E100", Offset = "0x343D100", VA = "0x18343E100")]
	private void OEFIIJGFJLN(TClaimant CBDBAGCKCGF, TNode JNHNIIABFGI, TNode BHNDMMJICPG, int PKMIOFBMBGD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x343E070", Offset = "0x343D070", VA = "0x18343E070")]
	private void LIAAKGBOOML(KCKONGGAAGH DDGODCOKJBK, GOBFPLHGBEF JPDHCAKHIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x343D7A0", Offset = "0x343C7A0", VA = "0x18343D7A0")]
	private void JBNHKEILPLH(TClaimant CBDBAGCKCGF, TNode JNHNIIABFGI, TNode BHNDMMJICPG, int PKMIOFBMBGD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x343D690", Offset = "0x343C690", VA = "0x18343D690")]
	private void IMNEDKKMLLC(KCKONGGAAGH DDGODCOKJBK, TNode NMNIBLLMCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x343DF70", Offset = "0x343CF70", VA = "0x18343DF70")]
	private void LELCCMAMNBD(KCKONGGAAGH DDGODCOKJBK, GOBFPLHGBEF JPDHCAKHIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x343D570", Offset = "0x343C570", VA = "0x18343D570")]
	private void GGIENCFJBGI(GOBFPLHGBEF JPDHCAKHIFL, bool AHMDCKCEJDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x343DB40", Offset = "0x343CB40", VA = "0x18343DB40")]
	private void KDDLDOAHBIF(GOBFPLHGBEF JPDHCAKHIFL, TNode COLDPDBGEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x343CFE0", Offset = "0x343BFE0", VA = "0x18343CFE0")]
	[IteratorStateMachine(typeof(GHNMEMFFNIH<, >.JEOKMAJEJKD))]
	private IEnumerable<TNode> BFAIJIIIBAG(TNode JNHNIIABFGI, TNode BHNDMMJICPG, bool JMLAEFNEJAF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x343DA00", Offset = "0x343CA00", VA = "0x18343DA00")]
	private GOBFPLHGBEF JHDJOJEJFFE(TNode NMNIBLLMCPD, TNode AGFCJPGACCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x343E4C0", Offset = "0x343D4C0", VA = "0x18343E4C0")]
	private GOBFPLHGBEF OOOPCNOCNBK(TNode NMNIBLLMCPD, TNode AGFCJPGACCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x343D3B0", Offset = "0x343C3B0", VA = "0x18343D3B0")]
	private void EPPNDJLABLK(GOBFPLHGBEF JPDHCAKHIFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class NIOJOCFPOBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	protected struct JDMEMPKACPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public T MNHGIJMEOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int HCMIGFDDFNN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly List<JDMEMPKACPN> INFBIEOEIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private T KAGEEPACFBF;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1C59E30", Offset = "0x1C58E30", VA = "0x181C59E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9A70", Offset = "0x2CB8A70", VA = "0x182CB9A70")]
	public bool FCOLACKIJCJ(T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9D90", Offset = "0x2CB8D90", VA = "0x182CB9D90")]
	public void KKDPLFKFCJN(T CKMKMNKGMMC, int AGNHICGKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9C70", Offset = "0x2CB8C70", VA = "0x182CB9C70")]
	public bool HBPDDHHFGHN(T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9A10", Offset = "0x2CB8A10", VA = "0x182CB9A10")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9FE0", Offset = "0x2CB8FE0", VA = "0x182CB9FE0")]
	public T NLHPDAOOHPF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2CB99A0", Offset = "0x2CB89A0", VA = "0x182CB99A0")]
	public T EDAHLOHNEFP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9E30", Offset = "0x2CB8E30", VA = "0x182CB9E30")]
	private void LGIBJKPOEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA050", Offset = "0x2CB9050", VA = "0x182CBA050")]
	public NIOJOCFPOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class NEHBDBJMLJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct CMOPFPBICNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int HCMIGFDDFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public T MNHGIJMEOAH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Dictionary<object, CMOPFPBICNJ> AINALLHHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly EqualityComparer<T> KDMNIBMHFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private T LHHLOFAHEHG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T ALAFPEFEHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x287E0D0", Offset = "0x287D0D0", VA = "0x18287E0D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x27F4A50", Offset = "0x27F3A50", VA = "0x1827F4A50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool IKCFKIMIDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x287E060", Offset = "0x287D060", VA = "0x18287E060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object MIIPKBCJDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA900", Offset = "0x2CA9900", VA = "0x182CAA900")]
	public bool APLDHGMAGCD(T CKMKMNKGMMC, object DMHDKAFNNAC, int AGNHICGKOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x287C540", Offset = "0x287B540", VA = "0x18287C540")]
	public bool AAMBGKOLHIL(object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x287C960", Offset = "0x287B960", VA = "0x18287C960")]
	public bool BBJOPJDJGON(object DMHDKAFNNAC, out T CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x287E030", Offset = "0x287D030", VA = "0x18287E030")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x287DD70", Offset = "0x287CD70", VA = "0x18287DD70")]
	private bool CHPJJOMKGPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x287E0E0", Offset = "0x287D0E0", VA = "0x18287E0E0")]
	public NEHBDBJMLJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OLHAKBALKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x713E6E0", Offset = "0x713D6E0", VA = "0x18713E6E0")]
	public static void IGOAKOLKHEN(OEMFJNEEEFM MCOHAKACPKD, string DFLIBMAEBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public static void IGOAKOLKHEN(IEnumerable<object> CGOEBBDIGKG, string DFLIBMAEBBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class BDOBCGJKGLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private bool GDJEDCJJAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private Action NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static BDOBCGJKGLO HACLKILKPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x713A480", Offset = "0x7139480", VA = "0x18713A480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8401D0", Offset = "0x83F1D0", VA = "0x1808401D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x713A500", Offset = "0x7139500", VA = "0x18713A500")]
	public BDOBCGJKGLO(Action NPNCNABHINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x713A460", Offset = "0x7139460", VA = "0x18713A460")]
	public void OHNMHKDFAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x713A460", Offset = "0x7139460", VA = "0x18713A460", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class INHAKODAJKD : NLPBKAFHPON
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x713B7D0", Offset = "0x713A7D0", VA = "0x18713B7D0")]
	public INHAKODAJKD(UnityEngine.Object EAMOHKJHBGE)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
