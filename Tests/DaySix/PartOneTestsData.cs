using System.Collections;
using System.Collections.Generic;

namespace Tests.DaySix;

public class PartOneTestsData : IEnumerable<object[]>
{
	public IEnumerator<object[]> GetEnumerator()
	{
		yield return new object[] {"mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7};
		yield return new object[] {"bvwbjplbgvbhsrlpgdmjqwftvncz", 5};
		yield return new object[] {"nppdvjthqldpwncqszvftbrmjlhg", 6};
		yield return new object[] {"nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10};
		yield return new object[] {"zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11};
		yield return new object[]
		{
			"vldvlvvhwhttcsttpntnvvqpqpddmlddwhwcwnwmwfwppdrrhllcwwgwhwvhwhshchshtsstzstztgtlggcwwtptrppfpggwpwmppnfpfnfznffmvfmvffgfwwwgrrqgglrgrqqlslhhgjgwwdswsbwwqswqwnqwqpqttqstqtjqqctcbtcbttcptpbbsmmhggwmggjllcpcvcrrphpjjwzwgzgtzggscggwdgghlhnhddlclrcchllrlbbnlbbgpbgghvggpbgpgssbszzjbbcpbpttwztwwgngnqqgllcvlvlzvzwwzssbppjwwvswwbjwbjwwwsjsdjsszmssfvsvcscqssnbnzbzzhsszttfvvdllzjzsjjzzvzsvzzdvvcpphfhzhrzrnnwffnrrhwrhrnrhnrrgfgmmzwmzmhzzsrzrgggnfntnpnqqdhhmrmrrqdqwqsqmssmllmvmgglttdmdffwzzhszhzphzphplpvpzvvsvcvgvqgqpgqqrmqmqssdbdcdpphddvppfggwrgrdgrggtvggrttmpmvmnmwnmmlcccwssfjftfbbgqbbnlldzlddzbbvmmvbmvvbsszggmnggqsqvssdlddqbbtfbttlhhlssplphlhzzcmmdcmmlqlqmmtddztzctzzlglwlzwwsmsddbrrzqqpdpjdpjjzhjjjzttvvwcvcdvvwqvvwqqgpgjgwgvgmmdjjmbbttmffwgwgppspzzvddjnjppmsscjczcqcczlzjzbbzmzllsshrrdtdttjdtdnnwbwttzptztrzzgfgfqfjjlwjjbfbsbmmhphqqjlqjjjshsvvrzrffvnfftrrpzzrdrbbcqbqjqccphhwfwgfwgwgwzzhggddctcsttjgjppghppfhhlnhhhwfwrfrggtjjgjbgbjbrrssjvvlcvvdzvdzzjhhgpprnpnpggfmfgfzfrzzsjjwhhrmmmvppgfffdsfddwlddmccjfcjjrwwsmwsstlsszbbjssjtsjjmpjpqqzffhphfffrzffnbnvnzvnvsvjjbljlflglrlvvghhcrhccnhccdbcdclcbbgffhwhnwwrwbbngnwwlpwlwsllsffzvzbzhbhppvdvfdvffvsvlslcslsqqszqzrrqbrrpjjvgjggbvvpbblnlvnnvrrprbpbvbccrjsdfrnqvhgfrwtvqjfzflnqqgbwlvfwwmrgnsltsqjfcctdwhqrstpvllhfrbnvnhvvgfvhbsgppslqnhmwdnrjnpfmrppppqpmrmcvtndrgwngrblpvrgnbhgtflthdjdtqhwcfzbdwsjshhnglprfcjfdwffmhbvhshbzsgdsbdwpcjfhrccqmjslqjjrwnbtqftqlvgnpmmzlfnmjzvrfslmmvhqwzjqbwsqfcnlmgdwlcbrlqlfwzhcfjsnncnnjqltfccmllhnjczqssjnjmhqbhqzdplbvfdpmdjmgthvqgjzqqschzgtmpdzmvvhlrwjpbqfplcqdbjfjfcrzdclctldvvqphtnvmgzvwprhzmbsbgfjlhvbtcmnccrgrpjlcjqqfcgjhtwvfstrtzszgcprmcngbhbdvjbfvgqdlhzgtzcjqnjmdtmwzchcfhzhgwprgrzbfwbhstfbprhnbzhsglmwhcjbppnshmzlnzsmbhcrmvpdgftfrwjfnmdvtrrqwjmzlbdjppsnvmlstsnrjwslqtqfmfcspzgrqhshhvclvqdfpbmzvsnthmcrzdmzqcjnnmbwbdlbfmcrzjjsrjbwchlvljplqdbjfchbslcvbjvvzfgdzmmnrgqwftppgpfwhfvdqqsrphrqmdtzjghlldfpgnczzjhqhfjvgqmcpzqssfqsfblcvqfttznpmvczprcptgcfwwlwsmqvfrjzcwbhppsjghmltqtcqljmpjzddncbslqdvgzhdvfpdpgpzljrfnjwdtnbdjwzjvmhqvnrdrjmhcfsbjcwtflljwjvtjbsbhzbghnzwtwpwzzwnfhwszsghggqthcbtwjrhdphbdslzmwhpmtjfbnpzspfqrvvtsjpvjmbtwrsqvfzzphllbvmvczsphdtblgdczjsqqthgscdqpvnmbpblspbcmpgjjtjtdrwhrqcgbrvlcsrwzwnjlgbfjbfgwpqpvnnmmgbdrhrwsptmddvtgbjhgzcphzmscjrqlnngpsnmjhvtmnhmqmcwdpjpbjsntcgppqrjndfsfhrhcvgcmrfrrsvnddwjsndlwffrgqnldqnvtgfvdrwtrlcqhltmbvdndzpdqndqrbtzqwbmbtzzsqftjftcnbrtsgvdrmnqlbbmhwmzpngltcslwdnpzpvstpdtfdcqvlwtbppsjvpdbspzlwnfvgcslzvmrpgplbnrvwpfwnrhcncdzptrjsqvghrczmrfwfntqlvlccwtbwqdcngzlqqvvnvfttqmcbqfqndhlsmbvcnstjcbpffmsptdnqbntnhhdctgdbnvwzgwznsgpvmslpmlcffsdtfnlcmbdgbntcslrlhfmrpddmjjttbtcrgbmfsbbwphtmlrdrgffdlnrwndhttjrplstwfwlpnljlcjphdvdvslwvnstqlrsgwdltlqwzdgsltzjqsgwqpbzgvqbdmvqtdgsnhttqprttzrnmddzdnqsgmnhfrmmfnrmltgjqpmgmdzdwpnzdsgstmwlgstmtjtqlhngmpwdqscrjmpmndddppsgthtbmznndswpsftcfltmhbbglnlmlszsssrlgbzcqpngvtgttlblsthmrltgctpgpjmhqqbldfgcrmclsmjhnjspzgwpmwncjgwrgdjmfgrpndztfdssmjhfmstgbjjzvmrpbmfzljpffwgvszwvtclfdnnbswzpjgthcbzpcbmgfvhfwnfthjdmnzdptqflzldnvnmfqnbggsrzjjssdntqhsjltjlfvjhncbrfbhllmqdpdnlbjptdcrqqghvvfvzzvtbvnjhshptcmgcnlmmpgdggdsfnpfsgrbcnfvrvfcqdfdfbgfvqcspvnrrljsgdtsbbcvcqnlwmrfgjhbdnjqgpggnpqtqgwspgljbrsggnmbmdbctwsdzqjmzrcwqgsvnhlpnlnqgfvgdfpgwsbqpqjcjpwwbrtzqhhgswggwnhmzwtvrqcrgbsrjspmczctgprgcwjtnzghvzqgnpmfqdswnzfzdbpdnpcgmwdrpmjtzhhwcnrrpfvqsgbrzngmwdgvjnmcftcjpcmdvcwjgfgvjrblsdnbsgfmjnvvvfwpfhztbgfddlcljzmwrwglnrfbnphlpvvcbfnwpsmsnhshzwrpnljzstmglrwdcctqlbwvqtfpjjdqzgncwgsnhczhvnvnzzmsjhfvgpdrhsmgnrfjcrzblzncdlffjrcqrqqdnjhgwgdgjlgbtphzgrjvmgnqrvdgmtgvpdbzqcvsfctrntjsnfcwnzpslzsvmtjhtcvcdsbqflbmtvclssrvcwjwcbspjgqhznzpttlbsnrpdrnqsddlcvjdrnqcgjhjfdclhwscdpbsjzcmrhgfwdnqbzqjsdqwbqdfcrztzfvclvbnhqstjztqdmsvlfqzmllphgrnwjqpdlrdnsbdltrggvlmdpfdwrdwnsdnscfcjzmrwqpsjwzrqcqcfndlvtfftbhdcbgcgtrfqrqnvwgbpstrtzgpjcjswfcwgvfnwlpprthntmlqbchjcwnqgppchgtvrzjbdzptfqqbmchmpqlnnfvpghjnmshpcjgsprbjpqnpwwddnswnfjvbzwszplhnhgzmzdqncmqrqtbqhdwbtrbrljpcwbdhjzvcqpdgvbtczlhwwzfmgvffnbcglpdqjdsnhhtnvvmtnhlbqcfqjfcgmcnqstzbgmqcfsgrzncwcfrlpsctpspvvdzwtbrhqzhfcwvwqvtzrmfjgpmlsdjmlgwhcldqlhsjvprvnmzcsldzfpzhmzdbqbpwnrsffswbjcwjgblnlcwzqlmcgfstqggdbsqpcpqcgfvn",
			1198
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}