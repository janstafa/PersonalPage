@echo on
 
echo starting sync
"..\Tools\WinSCP\winscp.com" /console /script="winscp_stafa_it.txt" /log="log.txt"
echo sync done

exit 0

